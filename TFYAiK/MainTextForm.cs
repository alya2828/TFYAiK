using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TFYAiK
{

    public partial class MainForm : Form
    {

        private static List<Char> listToRemove = new List<Char>() { ' ', '\n', '\t' }; 
        FileProvider FileProvider = new FileProvider();
        Stack<Func<object>> undoStack = new Stack<Func<object>>();
        Stack<Func<object>> redoStack = new Stack<Func<object>>();
        public MainForm()
        {
            InitializeComponent();
            textBox.KeyDown += textBox_KeyDown;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFile(textBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 1000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.saveButton, "Сохранить");
            toolTip.SetToolTip(this.undoButton, "Отменить");
            toolTip.SetToolTip(this.redoButton, "Вернуть");
            toolTip.SetToolTip(this.copyButton, "Копировать");
            toolTip.SetToolTip(this.pasteButton, "Вставить");
            toolTip.SetToolTip(this.cutButton, "Вырезать");
            toolTip.SetToolTip(this.createNewButton, "Создать файл");
            toolTip.SetToolTip(this.openNewButton, "Открыть файл");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLineNumbers();
            //HighlightSyntax(richTextBoxInput);
        }

        private void textBox_VScroll(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        private void UpdateLineNumbers()
        {
            int firstVisibleCharIndex = this.textBox.GetCharIndexFromPosition(new Point(0, 0));
            int firstVisibleLine = this.textBox.GetLineFromCharIndex(firstVisibleCharIndex);

            this.lineNumberRichTextBox.Clear();

            int lineCount = this.textBox.Lines.Length;
            int lastVisibleLine = firstVisibleLine + this.textBox.Height / this.textBox.Font.Height;

            for (int i = firstVisibleLine; i <= lastVisibleLine && i < lineCount; i++)
            {
                this.lineNumberRichTextBox.SelectionIndent = 5;
                this.lineNumberRichTextBox.AppendText((i + 1) + Environment.NewLine);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFileAs(textBox.Text);
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            FileProvider.CreateNewFile();
            this.textBox.Visible = true;
            this.lineNumberRichTextBox.Visible = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.SaveFile(textBox.Text);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProvider.CreateNewFile();
            this.textBox.Visible = true;
            this.lineNumberRichTextBox.Visible = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Text = FileProvider.OpenFile();
            this.textBox.Visible = true;
            this.lineNumberRichTextBox.Visible = true;
            UpdateLineNumbers();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Paste();
            
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Copy();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            if (this.textBox.SelectionLength > 0)
                this.textBox.Cut();
        }

        private void undo(object sender)
        {
            if (undoStack.Count > 0)
            {
                StackPush(sender, redoStack);
                undoStack.Pop()();
            }
        }

        private void redo(object sender)
        {
            if (redoStack.Count > 0)
            {
                StackPush(sender, undoStack);
                redoStack.Pop()();
            }
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            redo(textBox);
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                StackPush(textBox, redoStack);
                undoStack.Pop()();
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && ModifierKeys == Keys.Control) { }
            else if (!((e.KeyCode != Keys.U || ModifierKeys != Keys.Control)))
            {
                undo(sender);
            }
            else if (e.KeyCode == Keys.R && ModifierKeys == Keys.Control)
            {
                redo(sender);
            }
            else
            {
                redoStack.Clear();
                StackPush(sender, undoStack);
            }
        }

        private void StackPush(object sender, Stack<Func<object>> stack)
        {
            RichTextBox textBox = (RichTextBox)sender;
            var tBT = textBox.Text(textBox.Text, textBox.SelectionStart);
            stack.Push(tBT);
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.SelectAll();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Clear();
        }
        private void openDocument(string pathAfterCurrentDirectory)
        {
            try
            {
                string path = Environment.CurrentDirectory + pathAfterCurrentDirectory;
                System.Diagnostics.Process.Start(path);
            }
            catch { MessageBox.Show("Не найден соответствующий документ!", Name = "Открытие документа"); }
        }
        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\index.html");
        }

        private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox.Text == string.Empty)
                return;

            this.debugTextBox.Text = string.Empty;
            string expr = this.textBox.Text.Filter(listToRemove);

            List<Scanner.LexicalScanner.LexicalItem> expression = Scanner.LexicalScanner.GetTokens(this.textBox.Text.Filter(listToRemove));

            Scanner.Parser.ParseInit(expression);
           
            if (Scanner.Parser.s_errors.Count == 0)
            {
                this.debugTextBox.Text = $"Ошибок нет! {DateTime.Now}";
            }
            else
            {
                foreach (var error in Scanner.Parser.s_errors)
                {
                    this.debugTextBox.Text += $" Ошибка в позиции {error.position}: {error.message}\n";
                }
            }
            Scanner.Parser.ClearErrorsList();
        }

        private void УвеличитьМасштабToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newFontSize = this.textBox.Font.Size + 1;
            this.textBox.Font = new Font(this.textBox.Font.FontFamily, newFontSize);
            this.lineNumberRichTextBox.Font = new Font(this.lineNumberRichTextBox.Font.FontFamily,newFontSize);        
        }

        private void УменьшитьМасштабToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float newFontSize = this.textBox.Font.Size - 1;
            this.textBox.Font = new Font(this.textBox.Font.FontFamily, newFontSize);
            this.lineNumberRichTextBox.Font = new Font(this.lineNumberRichTextBox.Font.FontFamily, newFontSize);          
        }

        private void openNewButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = FileProvider.OpenFile();
            this.textBox.Visible = true;
            this.lineNumberRichTextBox.Visible = true;
            UpdateLineNumbers();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void постановкаЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Постановка-задачи.html");
        }

        private void грамматикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Грамматика.html");
        }

        private void классификацияГрамматикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Классификация-грамматики.html");
        }

        private void методАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Метод-анализа.html");
        }

        private void диагностикаИНейтрализацияОшибокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Диагностика-и-нейтрализация-ошибок.html");
        }

       

        private void списокЛитературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Список-литературы.html");
        }

        private void исходныйКодПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Исходный код программы.html");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Информация-о-программе.html");
        }

        private void тестовыйПримерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDocument("\\Help\\Тестовый-пример.html");
        }
    }

    public static class Extensions
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            String chars = "[" + String.Concat(charsToRemove) + "]";
            return Regex.Replace(str, chars, String.Empty);
        }
        public static Func<RichTextBox> Text(this RichTextBox textBox, string text, int sel)
        {
            return () =>
            {
                textBox.Text = text;
                textBox.SelectionStart = sel;
                return textBox;
            };
        }
    }
}
