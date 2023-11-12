namespace JobFinder
{
    partial class JobFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobFinder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PathButton = new System.Windows.Forms.Button();
            this.PathCombo = new System.Windows.Forms.ComboBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.JobButton = new System.Windows.Forms.Button();
            this.JobText = new System.Windows.Forms.TextBox();
            this.JobView = new System.Windows.Forms.DataGridView();
            this.JobNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).BeginInit();
            this.SuspendLayout();
            // 
            // PathButton
            // 
            resources.ApplyResources(this.PathButton, "PathButton");
            this.PathButton.Name = "PathButton";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // PathCombo
            // 
            resources.ApplyResources(this.PathCombo, "PathCombo");
            this.PathCombo.FormattingEnabled = true;
            this.PathCombo.Name = "PathCombo";
            // 
            // PathLabel
            // 
            resources.ApplyResources(this.PathLabel, "PathLabel");
            this.PathLabel.Name = "PathLabel";
            // 
            // JobLabel
            // 
            resources.ApplyResources(this.JobLabel, "JobLabel");
            this.JobLabel.Name = "JobLabel";
            // 
            // JobButton
            // 
            resources.ApplyResources(this.JobButton, "JobButton");
            this.JobButton.Name = "JobButton";
            this.JobButton.UseVisualStyleBackColor = true;
            this.JobButton.Click += new System.EventHandler(this.JobButton_Click);
            // 
            // JobText
            // 
            resources.ApplyResources(this.JobText, "JobText");
            this.JobText.Name = "JobText";
            this.JobText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JobText_KeyPress);
            // 
            // JobView
            // 
            this.JobView.AllowUserToAddRows = false;
            this.JobView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.JobView, "JobView");
            this.JobView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JobView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.JobView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobNumber,
            this.DateOrder,
            this.FileName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobView.DefaultCellStyle = dataGridViewCellStyle4;
            this.JobView.Name = "JobView";
            this.JobView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobView_CellContentClick);
            // 
            // JobNumber
            // 
            this.JobNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.JobNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.JobNumber.DividerWidth = 3;
            this.JobNumber.FillWeight = 515F;
            resources.ApplyResources(this.JobNumber, "JobNumber");
            this.JobNumber.Name = "JobNumber";
            this.JobNumber.ReadOnly = true;
            // 
            // DateOrder
            // 
            this.DateOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateOrder.DividerWidth = 3;
            this.DateOrder.FillWeight = 515F;
            resources.ApplyResources(this.DateOrder, "DateOrder");
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FileName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FileName.DividerWidth = 3;
            this.FileName.FillWeight = 515F;
            resources.ApplyResources(this.FileName, "FileName");
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // PathDialog
            // 
            this.PathDialog.ShowNewFolderButton = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // JobFinder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JobView);
            this.Controls.Add(this.JobText);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.JobButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathCombo);
            this.Controls.Add(this.PathButton);
            this.Name = "JobFinder";
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.ComboBox PathCombo;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Button JobButton;
        private System.Windows.Forms.TextBox JobText;
        private System.Windows.Forms.DataGridView JobView;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.FolderBrowserDialog PathDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

