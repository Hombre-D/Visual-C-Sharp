﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListViewBrowser
{
    public partial class ListViewForm : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        public ListViewForm()
        {
            InitializeComponent();
        }

        private void browserListView_Click(object sender, EventArgs e)
        {
            if(browserListView.SelectedItems.Count != 0)
            {
                if (browserListView.Items[0].Selected)
                {
                    DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);

                    if (directoryObject.Parent != null)
                    {
                        LoadFilesInDirectory(directoryObject.Parent.FullName);
                    }

                }

                else
                {
                    string chosen = browserListView.SelectedItems[0].Text;

                    if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
                    {
                        LoadFilesInDirectory(Path.Combine(currentDirectory, chosen));
                    }

                }

                label1.Text = currentDirectory;
            }
        }

        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                browserListView.Items.Clear();
                browserListView.Items.Add("Go up one level");

                currentDirectory = currentDirectoryValue;
                DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);

                DirectoryInfo[] directoryArray = newCurrentDirectory.GetDirectories();
                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                foreach(DirectoryInfo dir in directoryArray)
                {
                    ListViewItem newDirectoryItem = browserListView.Items.Add(dir.Name);
                    newDirectoryItem.ImageIndex = 0;
                }

                foreach(FileInfo file in fileArray)
                {
                    ListViewItem newFileItem = browserListView.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1;
                }

            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some files may not be " +
                    "visible due to permission settings",
                    "Attention", 0, MessageBoxIcon.Warning);
            }
        }

        private void ListViewForm_Load(object sender, EventArgs e)
        {
            fileFolderImageList.Images.Add(Properties.Resources.folder);
            fileFolderImageList.Images.Add(Properties.Resources.file);

            LoadFilesInDirectory(currentDirectory);
            label1.Text = currentDirectory;
        }
    }
}
