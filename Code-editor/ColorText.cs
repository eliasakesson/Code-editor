using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_editor
{
    internal class ColorText
    {
        string stringPattern = "\".*?\"";
        Color stringColor = Color.FromArgb(124, 177, 114);

        string commentPattern = @"//.*?$";
        Color commentColor = Color.FromArgb(100, 100, 100);

        string keywordPattern = @"\b(abstract|as|base|break|case|catch|checked|class|const|continue|default|delegate|do|else|enum|event|explicit|extern|finally|fixed|for|foreach|goto|if|implicit|in|interface|internal|is|lock|namespace|new|null|operator|out|override|params|private|protected|public|readonly|ref|return|sealed|sizeof|stackalloc|static|struct|switch|this|throw|try|typeof|unchecked|unsafe|using|virtual|void|volatile|while)\b";
        Color keywordColor = Color.FromArgb(186, 115, 219);

        string numberPattern = @"\b\d+\b";
        Color numberColor = Color.FromArgb(229, 192, 123);

        string dataTypePattern = @"\b(bool|byte|char|decimal|double|float|int|long|object|sbyte|short|string|uint|ulong|ushort)\b";
        Color dataTypeColor = Color.FromArgb(0, 206, 209);

        string bracketPattern = @"[\{\}\[\]\(\)]";
        Color bracketColor = Color.FromArgb(255, 255, 255);

        string htmlTagPattern = @"\b(div|span|p|a|img|table|tr|td|th|tbody|thead|tfoot|ul|li|ol|dl|dt|dd|form|input|textarea|select|option|button|label|fieldset|legend|iframe|script|style|link|meta|head|body|html)\b";
        Color htmlTagColor = Color.FromArgb(218, 99, 104);

        Color variableColor = Color.FromArgb(255, 0, 0);

        List<string> variables = new List<string>();

        string splitPattern = @"[\s\{\}\[\]\(\)\+\-\*\/\%\=\;\:\,\.\?\!\<\>\&\|\^\~\#\<[^<>]*>]";
        // @"(\s+|\.|,|;|\(|\)|\{|\}|\[|\]|=|\+|-|\*|/|!|\?|:|<|>)";
        public void ColorAllText(RichTextBox codeBox)
        {
            string code = codeBox.Text;
            codeBox.Text = "";
            string[] words = Regex.Split(code, splitPattern);
            
            ColorWords(codeBox, words);

            codeBox.SelectionColor = codeBox.ForeColor;
        }

        public void ColorCurrentLine(RichTextBox codeBox)
        {
            int selectionStart = codeBox.SelectionStart;
            int selectionLength = codeBox.SelectionLength;
            
            int line = codeBox.GetLineFromCharIndex(selectionStart);
            int lineStart = codeBox.GetFirstCharIndexFromLine(line);
            int lineEnd = codeBox.GetFirstCharIndexFromLine(line + 1);
            
            if (lineEnd == -1) lineEnd = codeBox.TextLength;
            
            int length = lineEnd - lineStart;
            codeBox.Select(lineStart, length);

            string code = codeBox.SelectedText;
            string[] words = Regex.Split(code, splitPattern);
            string[] word = new string[] { words[words.Length - 1] };

            int start = Math.Max(selectionStart - word[0].Length, 0);

            codeBox.Select(start, word[0].Length);
            Console.WriteLine(codeBox.SelectedText);

            ColorWords(codeBox, word);

            codeBox.SelectionColor = codeBox.ForeColor;
            codeBox.Select(selectionStart, selectionLength);
        }
        
        private void ColorWords(RichTextBox codeBox, string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word == " ")
                {
                    
                }
                else if (Regex.IsMatch(word, stringPattern))
                {
                    codeBox.SelectionColor = stringColor;
                }
                else if (Regex.IsMatch(word, commentPattern))
                {
                    codeBox.SelectionColor = commentColor;
                }
                else if (Regex.IsMatch(word, keywordPattern))
                {
                    codeBox.SelectionColor = keywordColor;
                }
                else if (Regex.IsMatch(word, numberPattern))
                {
                    codeBox.SelectionColor = numberColor;
                }
                else if (Regex.IsMatch(word, dataTypePattern))
                {
                    codeBox.SelectionColor = dataTypeColor;
                }
                else if (Regex.IsMatch(word, bracketPattern))
                {
                    codeBox.SelectionColor = bracketColor;
                }
                else if (Regex.IsMatch(word, htmlTagPattern))
                {
                    codeBox.SelectionColor = htmlTagColor;
                }
                else
                {
                    codeBox.SelectionColor = codeBox.ForeColor;
                }

                if (variables.Contains(word))
                {
                    codeBox.SelectionColor = variableColor;
                }
                else if (i > 1)
                {
                    if (Regex.IsMatch(words[i - 2], dataTypePattern))
                    {
                        codeBox.SelectionColor = variableColor;
                        variables.Add(word);
                    }
                }

                codeBox.SelectedText = word;
            }
        }
    }
}
