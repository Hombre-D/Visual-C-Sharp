using System;
using System.Windows.Forms;
using System.IO;
using BankLibrary;

namespace ReadSequentialAccessFIle
{
    public partial class ReadSequentialAccessForm : BankUIForm
    {
        private StreamReader fileReader;

        public ReadSequentialAccessForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(
                            fileName, FileMode.Open, FileAccess.Read);

                        fileReader = new StreamReader(input);

                        openFileButton.Enabled = false;
                        nextRecordButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Reading from File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void nextRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();

                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    SetTextBoxValues(inputFields);
                }
                else
                {
                    fileReader.Close();
                    openFileButton.Enabled = true;
                    nextRecordButton.Enabled = false;
                    ClearTextBoxes();
                    MessageBox.Show("No More Records in File", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (IOException)
            {
                MessageBox.Show("Error Reading from File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
