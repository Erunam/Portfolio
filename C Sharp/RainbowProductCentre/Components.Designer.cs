namespace RainbowStainedGlass
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
            this.cd_ComponentPart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cd_PartID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cd_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.c_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c_Name = new System.Windows.Forms.TextBox();
            this.c_Description = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.c_MC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.c_Cwp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.c_Awp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_ProductPart = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_Attribute = new System.Windows.Forms.TextBox();
            this.c_Group = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_Components = new System.Windows.Forms.DataGridView();
            this.ComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ds_next = new System.Windows.Forms.Button();
            this.ds_prev = new System.Windows.Forms.Button();
            this.b_Refresh = new System.Windows.Forms.Button();
            this.c_Load = new System.Windows.Forms.Button();
            this.c_SaveDetails = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_CDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_Components)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.c_CDetails);
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 276);
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
            this.cd_ComponentPart,
            this.cd_PartID,
            this.cd_Quantity});
            this.c_CDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_CDetails.Location = new System.Drawing.Point(3, 17);
            this.c_CDetails.Name = "c_CDetails";
            this.c_CDetails.RowHeadersWidth = 20;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.c_CDetails.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.c_CDetails.RowTemplate.Height = 23;
            this.c_CDetails.Size = new System.Drawing.Size(334, 256);
            this.c_CDetails.TabIndex = 0;
            this.c_CDetails.TabStop = false;
            this.c_CDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_CDetails_CellEndEdit);
            this.c_CDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.c_CDetails_DataError);
            // 
            // cd_ComponentPart
            // 
            this.cd_ComponentPart.DataPropertyName = "ComponentPart";
            this.cd_ComponentPart.FillWeight = 119.5432F;
            this.cd_ComponentPart.HeaderText = "Component Part";
            this.cd_ComponentPart.Name = "cd_ComponentPart";
            this.cd_ComponentPart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cd_ComponentPart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cd_PartID
            // 
            this.cd_PartID.DataPropertyName = "PartID";
            this.cd_PartID.FillWeight = 119.5432F;
            this.cd_PartID.HeaderText = "Part Name";
            this.cd_PartID.Name = "cd_PartID";
            this.cd_PartID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cd_PartID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cd_Quantity
            // 
            this.cd_Quantity.DataPropertyName = "Quantity";
            this.cd_Quantity.FillWeight = 60.9137F;
            this.cd_Quantity.HeaderText = "Quantity";
            this.cd_Quantity.Name = "cd_Quantity";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Component Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attribute";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.c_ID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.c_Name);
            this.groupBox3.Controls.Add(this.c_Description);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.c_MC);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.c_Cwp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.c_Awp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.c_ProductPart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.c_Attribute);
            this.groupBox3.Controls.Add(this.c_Group);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 301);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Component";
            // 
            // c_ID
            // 
            this.c_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_ID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.c_ID.Enabled = false;
            this.c_ID.Location = new System.Drawing.Point(106, 20);
            this.c_ID.Name = "c_ID";
            this.c_ID.Size = new System.Drawing.Size(228, 21);
            this.c_ID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Component ID";
            // 
            // c_Name
            // 
            this.c_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Name.Location = new System.Drawing.Point(106, 47);
            this.c_Name.Name = "c_Name";
            this.c_Name.Size = new System.Drawing.Size(228, 21);
            this.c_Name.TabIndex = 0;
            // 
            // c_Description
            // 
            this.c_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Description.Location = new System.Drawing.Point(106, 236);
            this.c_Description.Name = "c_Description";
            this.c_Description.Size = new System.Drawing.Size(228, 57);
            this.c_Description.TabIndex = 7;
            this.c_Description.TabStop = false;
            this.c_Description.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Description";
            // 
            // c_MC
            // 
            this.c_MC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_MC.Location = new System.Drawing.Point(106, 209);
            this.c_MC.Name = "c_MC";
            this.c_MC.Size = new System.Drawing.Size(228, 21);
            this.c_MC.TabIndex = 6;
            this.c_MC.Leave += new System.EventHandler(this.c_MC_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Material Cost";
            // 
            // c_Cwp
            // 
            this.c_Cwp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Cwp.Enabled = false;
            this.c_Cwp.Location = new System.Drawing.Point(106, 182);
            this.c_Cwp.Name = "c_Cwp";
            this.c_Cwp.Size = new System.Drawing.Size(228, 21);
            this.c_Cwp.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Parts WP";
            // 
            // c_Awp
            // 
            this.c_Awp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Awp.Location = new System.Drawing.Point(106, 155);
            this.c_Awp.Name = "c_Awp";
            this.c_Awp.Size = new System.Drawing.Size(228, 21);
            this.c_Awp.TabIndex = 4;
            this.c_Awp.Leave += new System.EventHandler(this.c_MC_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Assembly Time";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product Part";
            // 
            // c_ProductPart
            // 
            this.c_ProductPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_ProductPart.FormattingEnabled = true;
            this.c_ProductPart.Location = new System.Drawing.Point(106, 128);
            this.c_ProductPart.Name = "c_ProductPart";
            this.c_ProductPart.Size = new System.Drawing.Size(228, 21);
            this.c_ProductPart.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Group";
            // 
            // c_Attribute
            // 
            this.c_Attribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_Attribute.Location = new System.Drawing.Point(106, 74);
            this.c_Attribute.Name = "c_Attribute";
            this.c_Attribute.Size = new System.Drawing.Size(228, 21);
            this.c_Attribute.TabIndex = 1;
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
            this.c_Group.Location = new System.Drawing.Point(106, 101);
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
            this.groupBox1.Location = new System.Drawing.Point(358, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 526);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components And Parts";
            // 
            // c_Components
            // 
            this.c_Components.AllowUserToAddRows = false;
            this.c_Components.AllowUserToOrderColumns = true;
            this.c_Components.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.c_Components.CausesValidation = false;
            this.c_Components.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.c_Components.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentID,
            this.ProductPart,
            this.ComponentName,
            this.Attribute,
            this.Group,
            this.AWP,
            this.CWP,
            this.MC,
            this.Description});
            this.c_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Components.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.c_Components.Location = new System.Drawing.Point(3, 17);
            this.c_Components.Name = "c_Components";
            this.c_Components.RowHeadersWidth = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Components.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.c_Components.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.c_Components.RowTemplate.Height = 23;
            this.c_Components.Size = new System.Drawing.Size(419, 506);
            this.c_Components.TabIndex = 0;
            this.c_Components.TabStop = false;
            this.c_Components.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_Component_RowEnter);
            this.c_Components.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.c_Components_DataError);
            // 
            // ComponentID
            // 
            this.ComponentID.DataPropertyName = "ComponentID";
            this.ComponentID.HeaderText = "Component ID";
            this.ComponentID.Name = "ComponentID";
            // 
            // ProductPart
            // 
            this.ProductPart.DataPropertyName = "ProductPart";
            this.ProductPart.HeaderText = "Product Part";
            this.ProductPart.Name = "ProductPart";
            this.ProductPart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ComponentName
            // 
            this.ComponentName.DataPropertyName = "ComponentName";
            this.ComponentName.HeaderText = "Name";
            this.ComponentName.Name = "ComponentName";
            // 
            // Attribute
            // 
            this.Attribute.DataPropertyName = "Attribute";
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AWP
            // 
            this.AWP.DataPropertyName = "AWP";
            this.AWP.HeaderText = "Assembly WP";
            this.AWP.Name = "AWP";
            // 
            // CWP
            // 
            this.CWP.DataPropertyName = "CWP";
            this.CWP.HeaderText = "Parts WP";
            this.CWP.Name = "CWP";
            // 
            // MC
            // 
            this.MC.DataPropertyName = "MC";
            this.MC.HeaderText = "Material Cost";
            this.MC.Name = "MC";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.c_SaveDetails);
            this.groupBox4.Controls.Add(this.ds_next);
            this.groupBox4.Controls.Add(this.ds_prev);
            this.groupBox4.Controls.Add(this.b_Refresh);
            this.groupBox4.Controls.Add(this.c_Load);
            this.groupBox4.Location = new System.Drawing.Point(358, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // ds_next
            // 
            this.ds_next.Location = new System.Drawing.Point(43, 18);
            this.ds_next.Name = "ds_next";
            this.ds_next.Size = new System.Drawing.Size(31, 23);
            this.ds_next.TabIndex = 26;
            this.ds_next.TabStop = false;
            this.ds_next.Text = ">>";
            this.ds_next.UseVisualStyleBackColor = true;
            this.ds_next.Click += new System.EventHandler(this.ds_next_Click);
            // 
            // ds_prev
            // 
            this.ds_prev.Location = new System.Drawing.Point(6, 18);
            this.ds_prev.Name = "ds_prev";
            this.ds_prev.Size = new System.Drawing.Size(31, 23);
            this.ds_prev.TabIndex = 25;
            this.ds_prev.TabStop = false;
            this.ds_prev.Text = "<<";
            this.ds_prev.UseVisualStyleBackColor = true;
            this.ds_prev.Click += new System.EventHandler(this.ds_prev_Click);
            // 
            // b_Refresh
            // 
            this.b_Refresh.Location = new System.Drawing.Point(80, 18);
            this.b_Refresh.Name = "b_Refresh";
            this.b_Refresh.Size = new System.Drawing.Size(70, 23);
            this.b_Refresh.TabIndex = 2;
            this.b_Refresh.Text = "Refresh";
            this.b_Refresh.UseVisualStyleBackColor = true;
            this.b_Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_Load
            // 
            this.c_Load.Location = new System.Drawing.Point(329, 18);
            this.c_Load.Name = "c_Load";
            this.c_Load.Size = new System.Drawing.Size(90, 23);
            this.c_Load.TabIndex = 1;
            this.c_Load.Text = "Import design...";
            this.c_Load.UseVisualStyleBackColor = true;
            // 
            // c_SaveDetails
            // 
            this.c_SaveDetails.Location = new System.Drawing.Point(156, 18);
            this.c_SaveDetails.Name = "c_SaveDetails";
            this.c_SaveDetails.Size = new System.Drawing.Size(70, 23);
            this.c_SaveDetails.TabIndex = 27;
            this.c_SaveDetails.Text = "Details Save";
            this.c_SaveDetails.UseVisualStyleBackColor = true;
            this.c_SaveDetails.Click += new System.EventHandler(this.c_SaveDetails_Click);
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 540);
            this.Name = "Components";
            this.Text = "Components";
            this.Activated += new System.EventHandler(this.Components_Activated);
            this.Leave += new System.EventHandler(this.Components_Leave);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_CDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_Components)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView c_CDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox c_Attribute;
        private System.Windows.Forms.ComboBox c_Group;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox c_MC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox c_Cwp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c_Awp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c_ProductPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox c_Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView c_Components;
        private System.Windows.Forms.TextBox c_Name;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button c_Load;
        private System.Windows.Forms.TextBox c_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn AWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button b_Refresh;
        private System.Windows.Forms.DataGridViewComboBoxColumn cd_ComponentPart;
        private System.Windows.Forms.DataGridViewComboBoxColumn cd_PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_Quantity;
        private System.Windows.Forms.Button ds_next;
        private System.Windows.Forms.Button ds_prev;
        private System.Windows.Forms.Button c_SaveDetails;


    }
}