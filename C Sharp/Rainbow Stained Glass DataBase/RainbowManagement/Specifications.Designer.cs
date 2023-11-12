namespace RainbowManagement
{
    partial class Specifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Specifications));
            this.sp_PartClass = new System.Windows.Forms.TabControl();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.sp_Product = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_ProductCategories = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_pc_Product = new System.Windows.Forms.ComboBox();
            this.tabPage_Collections = new System.Windows.Forms.TabPage();
            this.sp_Collections = new System.Windows.Forms.DataGridView();
            this.ProductCollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Theme = new System.Windows.Forms.TabPage();
            this.sp_Themes = new System.Windows.Forms.DataGridView();
            this.ProductTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Component = new System.Windows.Forms.TabPage();
            this.sp_ComponentsCategories = new System.Windows.Forms.DataGridView();
            this.ComponentCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Part = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.PartClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_pc_PrCategories = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_PartClass.SuspendLayout();
            this.tabPage_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).BeginInit();
            this.tabPage_ProductCategories.SuspendLayout();
            this.tabPage_Collections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Collections)).BeginInit();
            this.tabPage_Theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Themes)).BeginInit();
            this.tabPage_Component.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComponentsCategories)).BeginInit();
            this.tabPage_Part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_pc_PrCategories)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_PartClass
            // 
            this.sp_PartClass.Controls.Add(this.tabPage_Product);
            this.sp_PartClass.Controls.Add(this.tabPage_ProductCategories);
            this.sp_PartClass.Controls.Add(this.tabPage_Collections);
            this.sp_PartClass.Controls.Add(this.tabPage_Theme);
            this.sp_PartClass.Controls.Add(this.tabPage_Component);
            this.sp_PartClass.Controls.Add(this.tabPage_Part);
            this.sp_PartClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_PartClass.Location = new System.Drawing.Point(0, 0);
            this.sp_PartClass.Name = "sp_PartClass";
            this.sp_PartClass.SelectedIndex = 0;
            this.sp_PartClass.Size = new System.Drawing.Size(583, 443);
            this.sp_PartClass.TabIndex = 0;
            // 
            // tabPage_Product
            // 
            this.tabPage_Product.Controls.Add(this.sp_Product);
            this.tabPage_Product.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Product.Name = "tabPage_Product";
            this.tabPage_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Product.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Product.TabIndex = 0;
            this.tabPage_Product.Text = "Products";
            this.tabPage_Product.UseVisualStyleBackColor = true;
            this.tabPage_Product.Enter += new System.EventHandler(this.tabPage_Product_Enter);
            // 
            // sp_Product
            // 
            this.sp_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Description});
            this.sp_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Product.Location = new System.Drawing.Point(3, 3);
            this.sp_Product.Name = "sp_Product";
            this.sp_Product.RowHeadersWidth = 20;
            this.sp_Product.RowTemplate.Height = 23;
            this.sp_Product.Size = new System.Drawing.Size(569, 411);
            this.sp_Product.TabIndex = 3;
            this.sp_Product.DoubleClick += new System.EventHandler(this.sp_Product_DoubleClick);
            // 
            // Product
            // 
            this.Product.FillWeight = 50.76142F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Description
            // 
            this.Description.FillWeight = 149.2386F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // tabPage_ProductCategories
            // 
            this.tabPage_ProductCategories.Controls.Add(this.groupBox2);
            this.tabPage_ProductCategories.Controls.Add(this.groupBox1);
            this.tabPage_ProductCategories.Controls.Add(this.label1);
            this.tabPage_ProductCategories.Controls.Add(this.sp_pc_Product);
            this.tabPage_ProductCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ProductCategories.Name = "tabPage_ProductCategories";
            this.tabPage_ProductCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ProductCategories.Size = new System.Drawing.Size(575, 417);
            this.tabPage_ProductCategories.TabIndex = 1;
            this.tabPage_ProductCategories.Text = "Product Categories";
            this.tabPage_ProductCategories.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // sp_pc_Product
            // 
            this.sp_pc_Product.FormattingEnabled = true;
            this.sp_pc_Product.Location = new System.Drawing.Point(61, 10);
            this.sp_pc_Product.Name = "sp_pc_Product";
            this.sp_pc_Product.Size = new System.Drawing.Size(195, 21);
            this.sp_pc_Product.TabIndex = 0;
            // 
            // tabPage_Collections
            // 
            this.tabPage_Collections.Controls.Add(this.sp_Collections);
            this.tabPage_Collections.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Collections.Name = "tabPage_Collections";
            this.tabPage_Collections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Collections.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Collections.TabIndex = 2;
            this.tabPage_Collections.Text = "Collections";
            this.tabPage_Collections.UseVisualStyleBackColor = true;
            // 
            // sp_Collections
            // 
            this.sp_Collections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Collections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCollection,
            this.CollectionDescription});
            this.sp_Collections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Collections.Location = new System.Drawing.Point(3, 3);
            this.sp_Collections.Name = "sp_Collections";
            this.sp_Collections.RowHeadersWidth = 20;
            this.sp_Collections.RowTemplate.Height = 23;
            this.sp_Collections.Size = new System.Drawing.Size(569, 411);
            this.sp_Collections.TabIndex = 1;
            // 
            // ProductCollection
            // 
            this.ProductCollection.FillWeight = 50.76142F;
            this.ProductCollection.HeaderText = "Collection";
            this.ProductCollection.Name = "ProductCollection";
            // 
            // CollectionDescription
            // 
            this.CollectionDescription.FillWeight = 149.2386F;
            this.CollectionDescription.HeaderText = "Description";
            this.CollectionDescription.Name = "CollectionDescription";
            // 
            // tabPage_Theme
            // 
            this.tabPage_Theme.Controls.Add(this.sp_Themes);
            this.tabPage_Theme.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Theme.Name = "tabPage_Theme";
            this.tabPage_Theme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Theme.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Theme.TabIndex = 3;
            this.tabPage_Theme.Text = "Themes";
            this.tabPage_Theme.UseVisualStyleBackColor = true;
            // 
            // sp_Themes
            // 
            this.sp_Themes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Themes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductTheme,
            this.ThemeDescription});
            this.sp_Themes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Themes.Location = new System.Drawing.Point(3, 3);
            this.sp_Themes.Name = "sp_Themes";
            this.sp_Themes.RowHeadersWidth = 20;
            this.sp_Themes.RowTemplate.Height = 23;
            this.sp_Themes.Size = new System.Drawing.Size(569, 411);
            this.sp_Themes.TabIndex = 2;
            // 
            // ProductTheme
            // 
            this.ProductTheme.FillWeight = 50.76142F;
            this.ProductTheme.HeaderText = "Theme";
            this.ProductTheme.Name = "ProductTheme";
            // 
            // ThemeDescription
            // 
            this.ThemeDescription.FillWeight = 149.2386F;
            this.ThemeDescription.HeaderText = "Description";
            this.ThemeDescription.Name = "ThemeDescription";
            // 
            // tabPage_Component
            // 
            this.tabPage_Component.Controls.Add(this.sp_ComponentsCategories);
            this.tabPage_Component.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Component.Name = "tabPage_Component";
            this.tabPage_Component.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Component.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Component.TabIndex = 4;
            this.tabPage_Component.Text = "Component Categories";
            this.tabPage_Component.UseVisualStyleBackColor = true;
            // 
            // sp_ComponentsCategories
            // 
            this.sp_ComponentsCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_ComponentsCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentCategory,
            this.CCategoryDescription});
            this.sp_ComponentsCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_ComponentsCategories.Location = new System.Drawing.Point(3, 3);
            this.sp_ComponentsCategories.Name = "sp_ComponentsCategories";
            this.sp_ComponentsCategories.RowHeadersWidth = 20;
            this.sp_ComponentsCategories.RowTemplate.Height = 23;
            this.sp_ComponentsCategories.Size = new System.Drawing.Size(569, 411);
            this.sp_ComponentsCategories.TabIndex = 3;
            // 
            // ComponentCategory
            // 
            this.ComponentCategory.FillWeight = 50.76142F;
            this.ComponentCategory.HeaderText = "Component";
            this.ComponentCategory.Name = "ComponentCategory";
            // 
            // CCategoryDescription
            // 
            this.CCategoryDescription.FillWeight = 149.2386F;
            this.CCategoryDescription.HeaderText = "Description";
            this.CCategoryDescription.Name = "CCategoryDescription";
            // 
            // tabPage_Part
            // 
            this.tabPage_Part.Controls.Add(this.dataGridView4);
            this.tabPage_Part.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Part.Name = "tabPage_Part";
            this.tabPage_Part.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Part.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Part.TabIndex = 5;
            this.tabPage_Part.Text = "Part Classes";
            this.tabPage_Part.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartClass,
            this.MaterialDescription});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 20;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(569, 411);
            this.dataGridView4.TabIndex = 3;
            // 
            // PartClass
            // 
            this.PartClass.FillWeight = 50.76142F;
            this.PartClass.HeaderText = "Part";
            this.PartClass.Name = "PartClass";
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.FillWeight = 149.2386F;
            this.MaterialDescription.HeaderText = "Description";
            this.MaterialDescription.Name = "MaterialDescription";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sp_pc_PrCategories);
            this.groupBox1.Location = new System.Drawing.Point(8, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 355);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 37);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // sp_pc_PrCategories
            // 
            this.sp_pc_PrCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sp_pc_PrCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_pc_PrCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_pc_PrCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category});
            this.sp_pc_PrCategories.Location = new System.Drawing.Point(6, 79);
            this.sp_pc_PrCategories.Name = "sp_pc_PrCategories";
            this.sp_pc_PrCategories.RowHeadersWidth = 20;
            this.sp_pc_PrCategories.RowTemplate.Height = 23;
            this.sp_pc_PrCategories.Size = new System.Drawing.Size(236, 269);
            this.sp_pc_PrCategories.TabIndex = 9;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(319, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 355);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(6, 36);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(236, 37);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(236, 269);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Specifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(583, 443);
            this.Controls.Add(this.sp_PartClass);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 470);
            this.Name = "Specifications";
            this.Text = "Specifications";
            this.sp_PartClass.ResumeLayout(false);
            this.tabPage_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).EndInit();
            this.tabPage_ProductCategories.ResumeLayout(false);
            this.tabPage_ProductCategories.PerformLayout();
            this.tabPage_Collections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Collections)).EndInit();
            this.tabPage_Theme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Themes)).EndInit();
            this.tabPage_Component.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComponentsCategories)).EndInit();
            this.tabPage_Part.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_pc_PrCategories)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sp_PartClass;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.TabPage tabPage_ProductCategories;
        private System.Windows.Forms.TabPage tabPage_Collections;
        private System.Windows.Forms.TabPage tabPage_Theme;
        private System.Windows.Forms.TabPage tabPage_Component;
        private System.Windows.Forms.TabPage tabPage_Part;
        private System.Windows.Forms.ComboBox sp_pc_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sp_Collections;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionDescription;
        private System.Windows.Forms.DataGridView sp_Themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThemeDescription;
        private System.Windows.Forms.DataGridView sp_ComponentsCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCategoryDescription;
        private System.Windows.Forms.DataGridView sp_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sp_pc_PrCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}