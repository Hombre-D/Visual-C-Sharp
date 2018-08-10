namespace ReadSequentialAccessFIle
{
    partial class ReadSequentialAccessForm
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.nextRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(62, 195);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(99, 48);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // nextRecordButton
            // 
            this.nextRecordButton.Location = new System.Drawing.Point(198, 195);
            this.nextRecordButton.Name = "nextRecordButton";
            this.nextRecordButton.Size = new System.Drawing.Size(99, 48);
            this.nextRecordButton.TabIndex = 9;
            this.nextRecordButton.Text = "Next Record";
            this.nextRecordButton.UseVisualStyleBackColor = true;
            this.nextRecordButton.Click += new System.EventHandler(this.nextRecordButton_Click);
            // 
            // ReadSequentialAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextRecordButton);
            this.Controls.Add(this.openFileButton);
            this.Name = "ReadSequentialAccessForm";
            this.Controls.SetChildIndex(this.openFileButton, 0);
            this.Controls.SetChildIndex(this.nextRecordButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button nextRecordButton;
    }
}

