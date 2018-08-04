namespace ListViewBrowser
{
    partial class ListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.browserListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // browserListView
            // 
            this.browserListView.Location = new System.Drawing.Point(28, 57);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(594, 324);
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.View = System.Windows.Forms.View.List;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.fileFolderImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browserListView);
            this.Name = "ListViewForm";
            this.Text = "ListViewForm";
            this.Load += new System.EventHandler(this.ListViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList fileFolderImageList;
    }
}

