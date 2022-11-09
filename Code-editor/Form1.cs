using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Code_editor
{
    public partial class Form1 : Form
    {
        // Round Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Title Bar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Code Input Field
        private void rtbxCode_TextChanged(object sender, EventArgs e)
        {
            lblNotSaved.Visible = true;

            // Get Keywords / Functions
            string keywords = @"\bpublic|private|partial|static|namespace|class|using|void|foreach|in|new\b";
            MatchCollection keywordMatches = Regex.Matches(rtbxCode.Text, keywords);
            Color keywordColor = Color.FromArgb(186, 115, 219);

            // Get Strings
            string strings = "\".*?\"";
            MatchCollection stringMatches = Regex.Matches(rtbxCode.Text, strings);
            Color stringColor = Color.FromArgb(124, 177, 114);

            // Get Comments
            string comments = @"//.+?$";
            MatchCollection commentMatches = Regex.Matches(rtbxCode.Text, comments);
            Color commentColor = Color.FromArgb(100, 100, 100);

            // Get Data Types
            string dataTypes = @"\bint|double|float|bool|char|byte|short|long|decimal|sbyte|ushort|uint|ulong\b";
            MatchCollection dataTypeMatches = Regex.Matches(rtbxCode.Text, dataTypes);
            Color dataTypeColor = Color.FromArgb(0, 206, 209);

            // Get Numbers
            string numbers = @"\b(0x)?[0-9]+\b";
            MatchCollection numberMatches = Regex.Matches(rtbxCode.Text, numbers);
            Color numberColor = Color.FromArgb(229, 192, 123);

            // Get Operators
            string operators = @"(\+|\-|\*|\/|\=|\%|\&|\||\^|\~|\!|\?|\<|\>|\:|\;|\,|\.)";
            MatchCollection operatorMatches = Regex.Matches(rtbxCode.Text, operators);
            Color operatorColor = Color.FromArgb(225, 225, 225);

            // Get Brackets
            string brackets = @"(\(|\)|\[|\]|\{|\})";
            MatchCollection bracketMatches = Regex.Matches(rtbxCode.Text, brackets);
            Color bracketColor = Color.FromArgb(195, 165, 109);

            int orgIndex = rtbxCode.SelectionStart;
            int orgLength = rtbxCode.SelectionLength;
            Color orgColor = Color.White;

            // Set Keywords / Functions Color
            foreach (Match match in keywordMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = keywordColor;

                rtbxCode.Select(orgIndex, orgLength);  
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Strings Color
            foreach (Match match in stringMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = stringColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Comments Color
            foreach (Match match in commentMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = commentColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Data Types Color
            foreach (Match match in dataTypeMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = dataTypeColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Numbers Color
            foreach (Match match in numberMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = numberColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Operators Color
            foreach (Match match in operatorMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = operatorColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            // Set Brackets Color
            foreach (Match match in bracketMatches)
            {
                rtbxCode.Select(match.Index, match.Length);
                rtbxCode.SelectionColor = bracketColor;

                rtbxCode.Select(orgIndex, orgLength);
                rtbxCode.SelectionColor = orgColor;
            }

            rtbxCode.Focus();
        }

        // Keys
        private void rtbxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)('"')){
                e.Handled = true;
                rtbxCode.SelectedText = "\"\"";
                rtbxCode.SelectionStart--;
            }
            else if (e.KeyChar == (char)('{')){
                e.Handled = true;
                rtbxCode.SelectedText = "{}";
                rtbxCode.SelectionStart--;
            }
            else if (e.KeyChar == (char)('(')){
                e.Handled = true;
                rtbxCode.SelectedText = "()";
                rtbxCode.SelectionStart--;
            }
            else if (e.KeyChar == (char)('[')){
                e.Handled = true;
                rtbxCode.SelectedText = "[]";
                rtbxCode.SelectionStart--;
            }
        }

        private void rtbxCode_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            // Code Helpers
            if (e.KeyCode == Keys.Tab)
            {
                if (e.Shift)
                {
                    // Reverse Indent
                    rtbxCode.Select(rtbxCode.SelectionStart - 4, 4);
                    if (rtbxCode.SelectedText == "    ")
                    {
                        rtbxCode.SelectedText = "";
                    }
                    else
                    {
                        rtbxCode.Select(rtbxCode.SelectionStart + 4, 0);
                    }
                }
                else
                {
                    // Indent
                    rtbxCode.Select(rtbxCode.SelectionStart, 4);
                    if (rtbxCode.SelectedText == "    ")
                    {
                        rtbxCode.Select(rtbxCode.SelectionStart + 4, 0);
                    }
                    else
                    {
                        rtbxCode.Select(rtbxCode.SelectionStart, 0);
                        rtbxCode.SelectedText = "    ";
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter && rtbxCode.SelectionStart > 0)
            {
                // Auto Layout
                rtbxCode.Select(rtbxCode.SelectionStart - 1, 2);

                if (rtbxCode.SelectedText == "{}")
                {
                    rtbxCode.SelectedText = "{" + Environment.NewLine + "    " + Environment.NewLine + "}";
                    rtbxCode.SelectionStart -= 2;
                } else if (rtbxCode.SelectedText == "()")
                {
                    rtbxCode.SelectedText = "(" + Environment.NewLine + "    " + Environment.NewLine + ")";
                    rtbxCode.SelectionStart -= 2;
                } else if (rtbxCode.SelectedText == "[]")
                {
                    rtbxCode.SelectedText = "[" + Environment.NewLine + "    " + Environment.NewLine + "]";
                    rtbxCode.SelectionStart -= 2;
                }
                else
                {
                    rtbxCode.Select(rtbxCode.SelectionStart + 1, 0);
                }
            }
            else
            {
                // Shortcuts
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.S:
                            Save();
                            break;
                        case Keys.N:
                            break;
                        default:
                            e.Handled = false;
                            e.SuppressKeyPress = false;
                            break;
                    }
                }
                else
                {
                    e.Handled = false;
                    e.SuppressKeyPress = false;
                }
            }
        }
        
        // Open Folder
        private void openFolderMenuItem_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog
            {
                InitialDirectory = "C:",
                Title = "Select a folder to open"
            };

            if (dialog.Show(Handle))
            {
                tvwProject.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(dialog.FileName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = tvwProject.Nodes.Add(di.Name, di.Name, 0, 1);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(dialog.FileName))
                {
                    FileInfo fi = new FileInfo(item);
                    var node = tvwProject.Nodes.Add(fi.Name, fi.Name, 2, 2);
                    node.Tag = fi;
                }
            }
        }

        // Select File
        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = "C:",
                Title = "Select a file to open"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(dialog.FileName);
                OpenFile(file);

                var node = tvwProject.Nodes.Add(file.Name, file.Name, 2, 2);
                node.Tag = file;
            }
        }

        // Open File
        FileInfo currentFileInfo;
        private void OpenFile(FileInfo file)
        {
            currentFileInfo = file;
            rtbxCode.Text = System.IO.File.ReadAllText(file.FullName);
            lblFileName.Text = file.Name;
            pnlFileHeader.Visible = true;
            lblNotSaved.Visible = false;
        }
       
        // Close File
        private void btnCloseFile_Click(object sender, EventArgs e)
        {
            currentFileInfo = null;
            rtbxCode.Text = String.Empty;
            lblFileName.Text = "code.cs";
            lblNotSaved.Visible = false;
        }

        // New File
        private void newFileMenuItem_Click(object sender, EventArgs e)
        {
            currentFileInfo = null;
            rtbxCode.Text = String.Empty;
            lblFileName.Text = "code.cs";
            lblNotSaved.Visible = false;
        }

        // Save Code
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (!string.IsNullOrEmpty(currentFileInfo?.FullName))
            {
                System.IO.File.WriteAllText(currentFileInfo.FullName, rtbxCode.Text);
                lblNotSaved.Visible = false;
            }
            else
            {
                SaveAs();
            }
        }

        // Save Code As
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = "C:",
                Title = "Select a folder to save file in",
                DefaultExt = "cs"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText($"{dialog.FileName}", rtbxCode.Text);
                FileInfo file = new FileInfo(dialog.FileName);
                OpenFile(file);

                var node = tvwProject.Nodes.Add(file.Name, file.Name, 2, 2);
                node.Tag = file;
            }
        }

        // File Tree
        private void tvwProject_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            if (e.Node.Tag is DirectoryInfo){
                e.Node.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(di.Name, di.Name, 0, 1);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo fi = new FileInfo(item);
                    var node = e.Node.Nodes.Add(fi.Name, fi.Name, 2, 2);
                    node.Tag = fi;
                }

                e.Node.Expand();
            }
            else if (e.Node.Tag is FileInfo)
            {
                OpenFile((FileInfo)e.Node.Tag);
            }
        }

    }
}
