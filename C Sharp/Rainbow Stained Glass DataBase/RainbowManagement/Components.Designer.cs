namespace RainbowManagement
{
    partial class Components
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Components));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c_CDetails = new System.Windows.Forms.DataGridView();
            this.cm_PartClass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cm_Component = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cm_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.c_Description = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.c_MC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.c_Cwp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.c_Awp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c_PartClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_Size = new System.Windows.Forms.TextBox();
            this.c_Group = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_Components = new System.Windows.Forms.DataGridView();
            this.ComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_CDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_Components)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.c_CDetails);
            this.groupBox2.Location = new System.Drawing.Point(15, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Component Details";
            // 
            // c_CDetails
            // 
            this.c_CDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_CDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.c_CDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.c_CDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cm_PartClass,
            this.cm_Component,
            this.cm_Quantity});
            this.c_CDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_CDetails.Location = new System.Drawing.Point(3, 17);
            this.c_CDetails.Name = "c_CDetails";
            this.c_CDetails.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.c_CDetails.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.c_CDetails.RowTemplate.Height = 23;
            this.c_CDetails.Size = new System.Drawing.Size(331, 183);
            this.c_CDetails.TabIndex = 0;
            this.c_CDetails.TabStop = false;
            // 
            // cm_PartClass
            // 
            this.cm_PartClass.FillWeight = 119.5432F;
            this.cm_PartClass.HeaderText = "Material Class";
            this.cm_PartClass.Name = "cm_PartClass";
            this.cm_PartClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cm_PartClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cm_Component
            // 
            this.cm_Component.FillWeight = 119.5432F;
            this.cm_Component.HeaderText = "Part Name";
            this.cm_Component.Name = "cm_Component";
            this.cm_Component.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cm_Component.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cm_Quantity
            // 
            this.cm_Quantity.FillWeight = 60.9137F;
            this.cm_Quantity.HeaderText = "Quantity";
            this.cm_Quantity.Name = "cm_Quantity";
            // 
            // c_Name
            // 
            this.c_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Name.FormattingEnabled = true;
            this.c_Name.Location = new System.Drawing.Point(105, 17);
            this.c_Name.Name = "c_Name";
            this.c_Name.Size = new System.Drawing.Size(228, 21);
            this.c_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Component Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Component Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.c_Description);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.c_MC);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.c_Cwp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.c_Awp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.c_PartClass);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.c_Category);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.c_Size);
            this.groupBox3.Controls.Add(this.c_Group);
            this.groupBox3.Controls.Add(this.c_Name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 295);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Component";
            // 
            // c_Description
            // 
            this.c_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Description.Location = new System.Drawing.Point(9, 231);
            this.c_Description.Name = "c_Description";
            this.c_Description.Size = new System.Drawing.Size(324, 59);
            this.c_Description.TabIndex = 25;
            this.c_Description.TabStop = false;
            this.c_Description.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Description";
            // 
            // c_MC
            // 
            this.c_MC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_MC.Location = new System.Drawing.Point(105, 188);
            this.c_MC.Name = "c_MC";
            this.c_MC.Size = new System.Drawing.Size(228, 21);
            this.c_MC.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Material Cost";
            // 
            // c_Cwp
            // 
            this.c_Cwp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Cwp.Enabled = false;
            this.c_Cwp.Location = new System.Drawing.Point(105, 165);
            this.c_Cwp.Name = "c_Cwp";
            this.c_Cwp.Size = new System.Drawing.Size(228, 21);
            this.c_Cwp.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Parts WP";
            // 
            // c_Awp
            // 
            this.c_Awp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Awp.Location = new System.Drawing.Point(105, 141);
            this.c_Awp.Name = "c_Awp";
            this.c_Awp.Size = new System.Drawing.Size(228, 21);
            this.c_Awp.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Assembly Time";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Material Class";
            // 
            // c_PartClass
            // 
            this.c_PartClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_PartClass.FormattingEnabled = true;
            this.c_PartClass.Location = new System.Drawing.Point(105, 116);
            this.c_PartClass.Name = "c_PartClass";
            this.c_PartClass.Size = new System.Drawing.Size(228, 21);
            this.c_PartClass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product Part";
            // 
            // c_Category
            // 
            this.c_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Category.FormattingEnabled = true;
            this.c_Category.Location = new System.Drawing.Point(105, 91);
            this.c_Category.Name = "c_Category";
            this.c_Category.Size = new System.Drawing.Size(228, 21);
            this.c_Category.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Group";
            // 
            // c_Size
            // 
            this.c_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Size.Location = new System.Drawing.Point(105, 42);
            this.c_Size.Name = "c_Size";
            this.c_Size.Size = new System.Drawing.Size(228, 21);
            this.c_Size.TabIndex = 1;
            // 
            // c_Group
            // 
            this.c_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.c_Group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_Group.FormattingEnabled = true;
            this.c_Group.Items.AddRange(new object[] {
            "Component",
            "Part"});
            this.c_Group.Location = new System.Drawing.Point(105, 66);
            this.c_Group.Name = "c_Group";
            this.c_Group.Size = new System.Drawing.Size(228, 21);
            this.c_Group.TabIndex = 2;
            this.c_Group.Text = "Component";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.c_Components);
            this.groupBox1.Location = new System.Drawing.Point(358, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 503);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components And Parts";
            // 
            // c_Components
            // 
            this.c_Components.AllowUserToAddRows = false;
            this.c_Components.AllowUserToOrderColumns = true;
            this.c_Components.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.c_Components.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.c_Components.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentID,
            this.ComponentName,
            this.Attribute,
            this.Group,
            this.ComponentCategory,
            this.PartClass,
            this.AWP,
            this.CWP,
            this.MC,
            this.Description});
            this.c_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Components.Location = new System.Drawing.Point(3, 17);
            this.c_Components.Name = "c_Components";
            this.c_Components.RowHeadersWidth = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Components.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.c_Components.RowTemplate.Height = 23;
            this.c_Components.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.c_Components.Size = new System.Drawing.Size(419, 483);
            this.c_Components.TabIndex = 0;
            this.c_Components.TabStop = false;
            // 
            // ComponentID
            // 
            this.ComponentID.HeaderText = "Component ID";
            this.ComponentID.Name = "ComponentID";
            // 
            // ComponentName
            // 
            this.ComponentName.HeaderText = "Name";
            this.ComponentName.Name = "ComponentName";
            // 
            // Attribute
            // 
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ComponentCategory
            // 
            this.ComponentCategory.HeaderText = "Product Part";
            this.ComponentCategory.Name = "ComponentCategory";
            this.ComponentCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PartClass
            // 
            this.PartClass.HeaderText = "Material Class";
            this.PartClass.Name = "PartClass";
            this.PartClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AWP
            // 
            this.AWP.HeaderText = "Assembly Time";
            this.AWP.Name = "AWP";
            // 
            // CWP
            // 
            this.CWP.HeaderText = "Parts WP";
            this.CWP.Name = "CWP";
            // 
            // MC
            // 
            this.MC.HeaderText = "Material Class";
            this.MC.Name = "MC";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 540);
            this.Name = "Components";
            this.Text = "Components";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_CDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_Components)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox c_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView c_CDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox c_Size;
        private System.Windows.Forms.ComboBox c_Group;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox c_MC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox c_Cwp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c_Awp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox c_PartClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox c_Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView c_Components;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn cm_PartClass;
        private System.Windows.Forms.DataGridViewComboBoxColumn cm_Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_Quantity;


    }
}