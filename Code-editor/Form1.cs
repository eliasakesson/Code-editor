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

namespace Code_editor
{
    public partial class Form1 : FormBase
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

        // Global Variables
        FileInfo currentFileInfo;
        DirectoryInfo currentDirectoryInfo;
        ColorText ct = new ColorText();

        public Form1()
        {
            InitializeComponent();
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.DoubleBuffered = true;
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.Blue;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
              borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
              ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
              borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        // Title Bar
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks >= 2)
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
            else
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

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

            //DisplayLineNumbers();

            ct.ColorCurrentLine(rtbxCode);
        }

        private void DisplayLineNumbers()
        {
            lblLineNumbers.Text = string.Empty;
            int lineCount = Math.Max(rtbxCode.Lines.Length, 1);

            for (int i = 1; i <= lineCount; i++)
            {
                lblLineNumbers.Text += i + "\n";
            }
        }

        // Keys
        private void rtbxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedText = rtbxCode.SelectedText;

            if (e.KeyChar == '"'){
                e.Handled = true;
                rtbxCode.SelectedText = $"\"{selectedText}\"";
                if (selectedText.Length <= 0)
                {
                    rtbxCode.SelectionStart--;
                }
            }
            else if (e.KeyChar == '{'){
                e.Handled = true;
                rtbxCode.SelectedText = "{" + selectedText + "}";
                if (selectedText.Length <= 0)
                {
                    rtbxCode.SelectionStart--;
                }
            }
            else if (e.KeyChar == '('){
                e.Handled = true;
                rtbxCode.SelectedText = $"({selectedText})";
                if (selectedText.Length <= 0)
                {
                    rtbxCode.SelectionStart--;
                }
            }
            else if (e.KeyChar == '['){
                e.Handled = true;
                rtbxCode.SelectedText = $"[{selectedText}]";
                if (selectedText.Length <= 0)
                {
                    rtbxCode.SelectionStart--;
                }
            }
            else if (e.KeyChar == '>')
            {
                return;
                int selectionStart = rtbxCode.SelectionStart;
                int selectionLength = rtbxCode.SelectionLength;

                int line = rtbxCode.GetLineFromCharIndex(selectionStart);
                int lineStart = rtbxCode.GetFirstCharIndexFromLine(line);

                int length = selectionStart - lineStart;
                rtbxCode.Select(lineStart, length);

                string code = rtbxCode.SelectedText;
                for (int i = code.Length - 1; i >= 0; i--)
                {
                    if (code[i] == '<')
                    {
                        string content = code.Substring(i + 1, length - i - 1);
                        rtbxCode.Select(selectionStart, selectionLength);
                        rtbxCode.SelectedText = $"</{content}>";
                        break;
                    } else if (!Char.IsLetter(code[i]))
                    {
                        break;
                    }
                }
                
                rtbxCode.Select(selectionStart, selectionLength);
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

                int indentLength = GetLineIndentLength();
                string indentString = new string(' ', indentLength);

                if (rtbxCode.SelectedText == "{}")
                {
                    rtbxCode.SelectedText = "{" + Environment.NewLine + indentString + "    " + Environment.NewLine + indentString + "}";
                    rtbxCode.SelectionStart -= 2 + indentLength;
                } else if (rtbxCode.SelectedText == "()")
                {
                    rtbxCode.SelectedText = "(" + Environment.NewLine + indentString + "    " + Environment.NewLine + indentString + ")";
                    rtbxCode.SelectionStart -= 2 + indentLength;
                } else if (rtbxCode.SelectedText == "[]")
                {
                    rtbxCode.SelectedText = "[" + Environment.NewLine + indentString + "    " + Environment.NewLine + indentString + "]";
                    rtbxCode.SelectionStart -= 2 + indentLength;
                } else
                {
                    rtbxCode.Select(rtbxCode.SelectionStart + 1, 0);
                    rtbxCode.SelectedText += Environment.NewLine + indentString;
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
                            CreateFile();
                            break;
                        case Keys.V:
                            ct.ColorAllText(rtbxCode);
                            e.Handled = false;
                            e.SuppressKeyPress = false;
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

        private int GetLineIndentLength()
        {
            int lineNr = rtbxCode.GetLineFromCharIndex(rtbxCode.SelectionStart);
            int lineStart = rtbxCode.GetFirstCharIndexFromLine(lineNr);
            int lineLength = rtbxCode.Lines[lineNr].Length;
            int indentLength = 0;
            for (int i = 0; i < lineLength; i++)
            {
                if (rtbxCode.Text[lineStart + i] == ' ')
                {
                    indentLength++;
                }
                else
                {
                    break;
                }
            }

            return indentLength;
        }
        
        // Open Folder
        private void openFolderMenuItem_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void SelectFolder()
        {
            FolderSelectDialog dialog = new FolderSelectDialog
            {
                InitialDirectory = "C:",
                Title = "Select a folder to open"
            };

            if (dialog.Show(Handle))
            {
                DirectoryInfo di = new DirectoryInfo(dialog.FileName);
                OpenFolder(di);
            }
        }

        private void OpenFolder(DirectoryInfo directoryInfo)
        {
            if (directoryInfo != null)
            {
                flpNoProject.Visible = false;
                flpProjectButtons.Visible = true;
                tvwProject.Nodes.Clear();

                currentDirectoryInfo = directoryInfo;
                lblProjectName.Text = currentDirectoryInfo.Name;

                foreach (var item in Directory.GetDirectories(directoryInfo.FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = tvwProject.Nodes.Add(di.Name, di.Name, 0, 1);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(directoryInfo.FullName))
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
            SelectFile();
        }

        private void SelectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = currentDirectoryInfo?.FullName != null ? currentDirectoryInfo.FullName : "C:",
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
        private void OpenFile(FileInfo file)
        {
            currentFileInfo = file;
            tbxFileName.ReadOnly = true;
            tbxFileName.Text = file.Name;
            pnlFileHeader.Visible = true;
            lblNotSaved.Visible = false;
            flpNoProject.Visible = false;
            flpCodeTabs.Visible = true;
            rtbxCode.Visible = true;
            rtbxCode.Text = File.ReadAllText(file.FullName);
            ct.ColorAllText(rtbxCode);
        }
       
        // Close File
        private void btnCloseFile_Click(object sender, EventArgs e)
        {
            currentFileInfo = null;
            tbxFileName.ReadOnly = false;
            rtbxCode.Text = String.Empty;
            pnlFileHeader.Visible = false;
            lblNotSaved.Visible = false;
            flpCodeTabs.Visible = false;
            rtbxCode.Visible = false;
            if (currentDirectoryInfo == null)
            { 
                flpNoProject.Visible = true;
            }
        }

        // New File
        private void newFileMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void CreateFile()
        {
            currentFileInfo = null;
            tbxFileName.ReadOnly = false;
            rtbxCode.Text = String.Empty;
            pnlFileHeader.Visible = true;
            lblNotSaved.Visible = false;
            flpCodeTabs.Visible = true;
            rtbxCode.Visible = true;
            tbxFileName.Text = "script.cs";
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
                File.WriteAllText(currentFileInfo.FullName, rtbxCode.Text);
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
                InitialDirectory = currentDirectoryInfo?.FullName != null ? currentDirectoryInfo.FullName : "C:",
                Title = "Select a folder to save file in",
                DefaultExt = "cs"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText($"{dialog.FileName}", rtbxCode.Text);
                FileInfo file = new FileInfo(dialog.FileName);
                OpenFile(file);
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
                    var node = e.Node.Nodes.Add(di.Name, di.Name, 0);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo fi = new FileInfo(item);
                    var node = e.Node.Nodes.Add(fi.Name, fi.Name, 2);
                    node.Tag = fi;
                }

                e.Node.Expand();
            }
            else if (e.Node.Tag is FileInfo)
            {
                OpenFile((FileInfo)e.Node.Tag);
            }
        }

        // No Tree Buttons
        private void btnNoTreeChooseFile_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void btnNoTreeChooseFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void btnNoTreeNewFile_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void btnAddProjectFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = currentDirectoryInfo?.FullName != null ? currentDirectoryInfo.FullName : "C:",
                Title = "Select a folder to save file in",
                DefaultExt = "cs"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(dialog.FileName).Close();

                FileInfo file = new FileInfo(dialog.FileName);
                OpenFile(file);

                var node = tvwProject.Nodes.Add(file.Name, file.Name, 2, 2);
                node.Tag = file;
            }
        }

        private void btnAddProjectFolder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProjectToggle_Click(object sender, EventArgs e)
        {
            flpProject.Visible = !flpProject.Visible;
        }

        private void tvwProject_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                e.Node.ImageIndex = 1;
            }            
        }

        private void tvwProject_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                e.Node.ImageIndex = 0;
            }
        }

        private void tbxFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
