namespace RainbowStainedGlass
{
    partial class Configurations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurations));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbt_Product = new System.Windows.Forms.DataGridView();
            this.cbt_ProductComponent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbt_ProductPartID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ProductSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Subcategory = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.cb_Product = new System.Windows.Forms.ComboBox();
            this.tabPage_Component = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbt_Component = new System.Windows.Forms.DataGridView();
            this.cbt_ComponentPart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbt_ComponentMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_ComponentSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Component = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Product.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbt_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage_Component.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbt_Component)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Product);
            this.tabControl1.Controls.Add(this.tabPage_Component);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Product
            // 
            this.tabPage_Product.Controls.Add(this.groupBox2);
            this.tabPage_Product.Controls.Add(this.groupBox1);
            this.tabPage_Product.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Product.Name = "tabPage_Product";
            this.tabPage_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Product.Size = new System.Drawing.Size(626, 432);
            this.tabPage_Product.TabIndex = 0;
            this.tabPage_Product.Text = "Product Configuration";
            this.tabPage_Product.UseVisualStyleBackColor = true;
            this.tabPage_Product.Leave += new System.EventHandler(this.tabPage_Product_Leave);
            this.tabPage_Product.Enter += new System.EventHandler(this.tabPage_Product_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbt_Product);
            this.groupBox2.Location = new System.Drawing.Point(195, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // cbt_Product
            // 
            this.cbt_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cbt_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cbt_Product.CausesValidation = false;
            this.cbt_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cbt_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbt_ProductComponent,
            this.cbt_ProductPartID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_Product.DefaultCellStyle = dataGridViewCellStyle1;
            this.cbt_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbt_Product.Location = new System.Drawing.Point(3, 17);
            this.cbt_Product.Name = "cbt_Product";
            this.cbt_Product.RowHeadersWidth = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_Product.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.cbt_Product.RowTemplate.Height = 23;
            this.cbt_Product.ShowCellErrors = false;
            this.cbt_Product.ShowRowErrors = false;
            this.cbt_Product.Size = new System.Drawing.Size(415, 393);
            this.cbt_Product.TabIndex = 0;
            // 
            // cbt_ProductComponent
            // 
            this.cbt_ProductComponent.HeaderText = "Component";
            this.cbt_ProductComponent.MaxDropDownItems = 16;
            this.cbt_ProductComponent.Name = "cbt_ProductComponent";
            this.cbt_ProductComponent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_ProductComponent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbt_ProductPartID
            // 
            this.cbt_ProductPartID.HeaderText = "Part ID";
            this.cbt_ProductPartID.Name = "cbt_ProductPartID";
            this.cbt_ProductPartID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_ProductPartID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cb_ProductSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Subcategory);
            this.groupBox1.Controls.Add(this.cb_Category);
            this.groupBox1.Controls.Add(this.cb_Product);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // cb_ProductSave
            // 
            this.cb_ProductSave.Location = new System.Drawing.Point(10, 241);
            this.cb_ProductSave.Name = "cb_ProductSave";
            this.cb_ProductSave.Size = new System.Drawing.Size(156, 23);
            this.cb_ProductSave.TabIndex = 3;
            this.cb_ProductSave.Text = "Save";
            this.cb_ProductSave.UseVisualStyleBackColor = true;
            this.cb_ProductSave.Click += new System.EventHandler(this.cb_ProductSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subcategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product";
            // 
            // cb_Subcategory
            // 
            this.cb_Subcategory.FormattingEnabled = true;
            this.cb_Subcategory.Location = new System.Drawing.Point(10, 177);
            this.cb_Subcategory.Name = "cb_Subcategory";
            this.cb_Subcategory.Size = new System.Drawing.Size(156, 21);
            this.cb_Subcategory.TabIndex = 2;
            this.cb_Subcategory.SelectedIndexChanged += new System.EventHandler(this.cb_Subcategory_SelectedIndexChanged);
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(10, 113);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(156, 21);
            this.cb_Category.TabIndex = 1;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // cb_Product
            // 
            this.cb_Product.FormattingEnabled = true;
            this.cb_Product.Location = new System.Drawing.Point(10, 49);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(156, 21);
            this.cb_Product.TabIndex = 0;
            this.cb_Product.SelectedIndexChanged += new System.EventHandler(this.cb_Product_SelectedIndexChanged);
            // 
            // tabPage_Component
            // 
            this.tabPage_Component.Controls.Add(this.groupBox3);
            this.tabPage_Component.Controls.Add(this.groupBox4);
            this.tabPage_Component.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Component.Name = "tabPage_Component";
            this.tabPage_Component.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Component.Size = new System.Drawing.Size(626, 432);
            this.tabPage_Component.TabIndex = 1;
            this.tabPage_Component.Text = "Component Configuration";
            this.tabPage_Component.UseVisualStyleBackColor = true;
            this.tabPage_Component.Leave += new System.EventHandler(this.tabPage_Component_Leave);
            this.tabPage_Component.Enter += new System.EventHandler(this.tabPage_Component_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbt_Component);
            this.groupBox3.Location = new System.Drawing.Point(195, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 413);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // cbt_Component
            // 
            this.cbt_Component.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cbt_Component.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_Component.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cbt_Component.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cbt_Component.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbt_ComponentPart,
            this.cbt_ComponentMaterial});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_Component.DefaultCellStyle = dataGridViewCellStyle4;
            this.cbt_Component.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbt_Component.Location = new System.Drawing.Point(3, 17);
            this.cbt_Component.Name = "cbt_Component";
            this.cbt_Component.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_Component.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cbt_Component.RowTemplate.Height = 23;
            this.cbt_Component.Size = new System.Drawing.Size(415, 393);
            this.cbt_Component.TabIndex = 0;
            // 
            // cbt_ComponentPart
            // 
            this.cbt_ComponentPart.HeaderText = "Part";
            this.cbt_ComponentPart.Name = "cbt_ComponentPart";
            this.cbt_ComponentPart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_ComponentPart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbt_ComponentMaterial
            // 
            this.cbt_ComponentMaterial.HeaderText = "Material ID";
            this.cbt_ComponentMaterial.Name = "cbt_ComponentMaterial";
            this.cbt_ComponentMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbt_ComponentMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cb_ComponentSave);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cb_Component);
            this.groupBox4.Location = new System.Drawing.Point(9, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 413);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Component";
            // 
            // cb_ComponentSave
            // 
            this.cb_ComponentSave.Location = new System.Drawing.Point(10, 113);
            this.cb_ComponentSave.Name = "cb_ComponentSave";
            this.cb_ComponentSave.Size = new System.Drawing.Size(156, 23);
            this.cb_ComponentSave.TabIndex = 1;
            this.cb_ComponentSave.Text = "Save";
            this.cb_ComponentSave.UseVisualStyleBackColor = true;
            this.cb_ComponentSave.Click += new System.EventHandler(this.cb_ComponentSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Component";
            // 
            // cb_Component
            // 
            this.cb_Component.FormattingEnabled = true;
            this.cb_Component.Location = new System.Drawing.Point(10, 49);
            this.cb_Component.Name = "cb_Component";
            this.cb_Component.Size = new System.Drawing.Size(156, 21);
            this.cb_Component.TabIndex = 0;
            this.cb_Component.SelectedIndexChanged += new System.EventHandler(this.cb_Component_SelectedIndexChanged);
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 470);
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Product.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbt_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Component.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbt_Component)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.TabPage tabPage_Component;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cbt_Product;
        private System.Windows.Forms.ComboBox cb_Subcategory;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.ComboBox cb_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_Component;
        private System.Windows.Forms.DataGridView cbt_Component;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cb_ProductSave;
        private System.Windows.Forms.Button cb_ComponentSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbt_ComponentPart;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbt_ComponentMaterial;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbt_ProductComponent;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbt_ProductPartID;
    }
}