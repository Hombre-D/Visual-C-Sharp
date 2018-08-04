using System;
using System.Windows.Forms;
using System.IO;

namespace FileBrowser
{
    public partial class Browser : Form
    {
        string substringDirectory;

        public Browser()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);
                        TreeNode myNode = new TreeNode(substringDirectory);
                        parentNode.Nodes.Add(myNode);
                        PopulateTreeView(directory, myNode);
                    }
                }
            }

            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            if (Directory.Exists(textBox1.Text))
            {
                treeView1.Nodes.Add(textBox1.Text);

                PopulateTreeView(textBox1.Text, treeView1.Nodes[0]);
            }

            else
            {
                MessageBox.Show(textBox1.Text + "could not be found.",
                    "Directory Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
