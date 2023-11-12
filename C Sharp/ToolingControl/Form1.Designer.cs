namespace ToolongControl
{
    partial class Tooling
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
            this.bOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PIList = new System.Windows.Forms.CheckedListBox();
            this.startExpr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopExpr = new System.Windows.Forms.ComboBox();
            this.TestExpression = new System.Windows.Forms.Button();
            this.Parsing = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ShowAllDone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowRegion = new System.Windows.Forms.Button();
            this.OutputWindow = new System.Windows.Forms.ListBox();
            this.ClearParsed = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Separate = new System.Windows.Forms.Button();
            this.Rubishes = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 35);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(142, 23);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "Open Files ...";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog1.Multiselect = true;
            //this.openFileDialog1.RestoreDirectory = true;
            // 
            // PIList
            // 
            this.PIList.FormattingEnabled = true;
            this.PIList.Location = new System.Drawing.Point(12, 67);
            this.PIList.Name = "PIList";
            this.PIList.Size = new System.Drawing.Size(142, 499);
            this.PIList.Sorted = true;
            this.PIList.TabIndex = 3;
            // 
            // startExpr
            // 
            this.startExpr.FormattingEnabled = true;
            this.startExpr.Items.AddRange(new object[] {
            "\\d{1}\\.\\d{1}.*Equipment.*Tools",
            "TOOLING/EQUIPMENT"});
            this.startExpr.Location = new System.Drawing.Point(275, 10);
            this.startExpr.Name = "startExpr";
            this.startExpr.Size = new System.Drawing.Size(397, 21);
            this.startExpr.TabIndex = 4;
            this.startExpr.Leave += new System.EventHandler(this.startExpr_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Reg. Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stop Reg. Expression";
            // 
            // stopExpr
            // 
            this.stopExpr.FormattingEnabled = true;
            this.stopExpr.Items.AddRange(new object[] {
            "\\d{1}\\.\\d{1}.*BOM.*Part",
            "OPERATION:"});
            this.stopExpr.Location = new System.Drawing.Point(275, 37);
            this.stopExpr.Name = "stopExpr";
            this.stopExpr.Size = new System.Drawing.Size(397, 21);
            this.stopExpr.TabIndex = 6;
            this.stopExpr.Leave += new System.EventHandler(this.stopExpr_Leave);
            // 
            // TestExpression
            // 
            this.TestExpression.Location = new System.Drawing.Point(160, 93);
            this.TestExpression.Name = "TestExpression";
            this.TestExpression.Size = new System.Drawing.Size(68, 23);
            this.TestExpression.TabIndex = 8;
            this.TestExpression.Text = "Test Expression";
            this.TestExpression.UseVisualStyleBackColor = true;
            this.TestExpression.Click += new System.EventHandler(this.TestExpression_Click);
            // 
            // Parsing
            // 
            this.Parsing.Location = new System.Drawing.Point(382, 93);
            this.Parsing.Name = "Parsing";
            this.Parsing.Size = new System.Drawing.Size(68, 23);
            this.Parsing.TabIndex = 9;
            this.Parsing.Text = "Parsing";
            this.Parsing.UseVisualStyleBackColor = true;
            this.Parsing.Click += new System.EventHandler(this.Parsing_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(604, 93);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(68, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save Output";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ShowAllDone
            // 
            this.ShowAllDone.Location = new System.Drawing.Point(456, 93);
            this.ShowAllDone.Name = "ShowAllDone";
            this.ShowAllDone.Size = new System.Drawing.Size(68, 23);
            this.ShowAllDone.TabIndex = 11;
            this.ShowAllDone.Text = "Show Extr.";
            this.ShowAllDone.UseVisualStyleBackColor = true;
            this.ShowAllDone.Click += new System.EventHandler(this.ShowAllDone_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowRegion
            // 
            this.ShowRegion.Location = new System.Drawing.Point(234, 93);
            this.ShowRegion.Name = "ShowRegion";
            this.ShowRegion.Size = new System.Drawing.Size(68, 23);
            this.ShowRegion.TabIndex = 13;
            this.ShowRegion.Text = "Region";
            this.ShowRegion.UseVisualStyleBackColor = true;
            this.ShowRegion.Click += new System.EventHandler(this.ShowRegion_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.FormattingEnabled = true;
            this.OutputWindow.Location = new System.Drawing.Point(162, 120);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(510, 446);
            this.OutputWindow.TabIndex = 14;
            // 
            // ClearParsed
            // 
            this.ClearParsed.Location = new System.Drawing.Point(530, 93);
            this.ClearParsed.Name = "ClearParsed";
            this.ClearParsed.Size = new System.Drawing.Size(68, 23);
            this.ClearParsed.TabIndex = 15;
            this.ClearParsed.Text = "Clear Extr.";
            this.ClearParsed.UseVisualStyleBackColor = true;
            this.ClearParsed.Click += new System.EventHandler(this.ClearParsed_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cleaning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rubish characters";
            // 
            // Separate
            // 
            this.Separate.Location = new System.Drawing.Point(506, 63);
            this.Separate.Name = "Separate";
            this.Separate.Size = new System.Drawing.Size(80, 23);
            this.Separate.TabIndex = 19;
            this.Separate.Text = "Separate IDs";
            this.Separate.UseVisualStyleBackColor = true;
            this.Separate.Click += new System.EventHandler(this.Separate_Click);
            // 
            // Rubishes
            // 
            this.Rubishes.FormattingEnabled = true;
            this.Rubishes.Items.AddRange(new object[] {
            "*-",
            "SU\\d+\\w*\\-*\\w*",
            "M\\d+\\w*\\-*\\w*",
            "VS\\d+\\w*\\-*\\w*",
            "T\\d{2,}\\w*\\-*\\w*",
            "SUG\\d+\\w*\\-*\\w*",
            "TS\\d+\\w*\\-*\\w*"});
            this.Rubishes.Location = new System.Drawing.Point(275, 65);
            this.Rubishes.Name = "Rubishes";
            this.Rubishes.Size = new System.Drawing.Size(225, 21);
            this.Rubishes.TabIndex = 20;
            this.Rubishes.Leave += new System.EventHandler(this.Rubishes_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Show File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tooling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 578);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rubishes);
            this.Controls.Add(this.Separate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearParsed);
            this.Controls.Add(this.ShowRegion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAllDone);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Parsing);
            this.Controls.Add(this.TestExpression);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopExpr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startExpr);
            this.Controls.Add(this.PIList);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.OutputWindow);
            this.Name = "Tooling";
            this.Text = "Tooling Control Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckedListBox PIList;
        private System.Windows.Forms.ComboBox startExpr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stopExpr;
        private System.Windows.Forms.Button TestExpression;
        private System.Windows.Forms.Button Parsing;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ShowAllDone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowRegion;
        private System.Windows.Forms.ListBox OutputWindow;
        private System.Windows.Forms.Button ClearParsed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Separate;
        private System.Windows.Forms.ComboBox Rubishes;
        private System.Windows.Forms.Button button3;
    }
}

