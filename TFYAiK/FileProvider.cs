using System.IO;
using System.Windows.Forms;

namespace TFYAiK
{
    public class FileProvider
    {
        private string currentFile;

        public FileProvider()
        {
            this.currentFile = null;
        }

        public FileProvider(string name)
        {
            this.currentFile = name;
        }

        public void SaveFileAs(string text)
        {
            if (text == "")
            {            
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.RestoreDirectory = true; ;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                this.currentFile = saveFileDialog.FileName;
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }

        public void SaveFile(string text)
        {
            if (currentFile == null)
            {
                SaveFileAs(text);
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(currentFile);
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }

        public void CreateNewFile()
        {
            SaveFileDialog CreateFileDialog = new SaveFileDialog();
            CreateFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            CreateFileDialog.Title = "Создать";

            if (CreateFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.currentFile = CreateFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(this.currentFile);
                streamWriter.Close();
            }
        }

        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text |*.txt|All files (*.*)|*.*";
            string fileText = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.currentFile = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(this.currentFile);
                fileText = streamReader.ReadToEnd();
                streamReader.Close();
            }
            return fileText;
        }
    }
}
