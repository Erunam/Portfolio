namespace MedtronicTaskList
{
    partial class TaskList
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
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.FileOpen = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.idText = new System.Windows.Forms.TextBox();
            this.descText = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.Label();
            this.AddButon = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileListBox
            // 
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(4, 8);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(265, 212);
            this.FileListBox.TabIndex = 0;
            // 
            // FileOpen
            // 
            this.FileOpen.Location = new System.Drawing.Point(276, 8);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(75, 23);
            this.FileOpen.TabIndex = 1;
            this.FileOpen.Text = "Open";
            this.FileOpen.UseVisualStyleBackColor = true;
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(275, 37);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(4, 280);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(347, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.Multiselect = true;
            this.OpenFileDlg.SupportMultiDottedExtensions = true;
            // 
            // SaveFileDlg
            // 
            this.SaveFileDlg.DefaultExt = "txt";
            this.SaveFileDlg.Filter = "Text files (*.txt)|*.txt";
            this.SaveFileDlg.SupportMultiDottedExtensions = true;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(65, 227);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(204, 20);
            this.idText.TabIndex = 4;
            // 
            // descText
            // 
            this.descText.Location = new System.Drawing.Point(65, 254);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(286, 20);
            this.descText.TabIndex = 5;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(1, 230);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(40, 13);
            this.idlabel.TabIndex = 6;
            this.idlabel.Text = "Part ID";
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Location = new System.Drawing.Point(1, 257);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(60, 13);
            this.descrLabel.TabIndex = 7;
            this.descrLabel.Text = "Description";
            // 
            // AddButon
            // 
            this.AddButon.Location = new System.Drawing.Point(276, 225);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(75, 23);
            this.AddButon.TabIndex = 8;
            this.AddButon.Text = "Add";
            this.AddButon.UseVisualStyleBackColor = true;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(275, 67);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(276, 196);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 10;
            this.About.Text = "About ...";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 309);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AddButon);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.FileOpen);
            this.Controls.Add(this.FileListBox);
            this.Name = "TaskList";
            this.Text = "Task List Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.Button FileOpen;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.SaveFileDialog SaveFileDlg;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.Button AddButon;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button About;
    }
}

