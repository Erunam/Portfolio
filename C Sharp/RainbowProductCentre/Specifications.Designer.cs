namespace RainbowStainedGlass
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
            this.tabPage_Collections = new System.Windows.Forms.TabPage();
            this.sp_Collections = new System.Windows.Forms.DataGridView();
            this.ProductCollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_SubCategory = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.sp_ps_category = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sp_Subcategories = new System.Windows.Forms.DataGridView();
            this.Subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubcategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_ps_product = new System.Windows.Forms.ComboBox();
            this.tabPage_ProductCategories = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sp_Categories = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_pc_Product = new System.Windows.Forms.ComboBox();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.sp_Product = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_SpecyficationsTab = new System.Windows.Forms.TabControl();
            this.tabPage_Theme = new System.Windows.Forms.TabPage();
            this.sp_Themes = new System.Windows.Forms.DataGridView();
            this.ProductTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Component = new System.Windows.Forms.TabPage();
            this.sp_ComponentsCategories = new System.Windows.Forms.DataGridView();
            this.ComponentCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Part = new System.Windows.Forms.TabPage();
            this.sp_Parts = new System.Windows.Forms.DataGridView();
            this.PartClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_License = new System.Windows.Forms.TabPage();
            this.sp_License = new System.Windows.Forms.DataGridView();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Collections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Collections)).BeginInit();
            this.tabPage_SubCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Subcategories)).BeginInit();
            this.tabPage_ProductCategories.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Categories)).BeginInit();
            this.tabPage_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).BeginInit();
            this.sp_SpecyficationsTab.SuspendLayout();
            this.tabPage_Theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Themes)).BeginInit();
            this.tabPage_Component.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComponentsCategories)).BeginInit();
            this.tabPage_Part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Parts)).BeginInit();
            this.tabPage_License.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_License)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Collections
            // 
            this.tabPage_Collections.Controls.Add(this.sp_Collections);
            this.tabPage_Collections.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Collections.Name = "tabPage_Collections";
            this.tabPage_Collections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Collections.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Collections.TabIndex = 7;
            this.tabPage_Collections.Text = "Collections";
            this.tabPage_Collections.UseVisualStyleBackColor = true;
            this.tabPage_Collections.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_Collections.Enter += new System.EventHandler(this.tabPage_Enter);
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
            // tabPage_SubCategory
            // 
            this.tabPage_SubCategory.Controls.Add(this.label3);
            this.tabPage_SubCategory.Controls.Add(this.sp_ps_category);
            this.tabPage_SubCategory.Controls.Add(this.groupBox2);
            this.tabPage_SubCategory.Controls.Add(this.label2);
            this.tabPage_SubCategory.Controls.Add(this.sp_ps_product);
            this.tabPage_SubCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SubCategory.Name = "tabPage_SubCategory";
            this.tabPage_SubCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SubCategory.Size = new System.Drawing.Size(575, 417);
            this.tabPage_SubCategory.TabIndex = 6;
            this.tabPage_SubCategory.Text = "Product Subcategory";
            this.tabPage_SubCategory.UseVisualStyleBackColor = true;
            this.tabPage_SubCategory.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_SubCategory.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category";
            // 
            // sp_ps_category
            // 
            this.sp_ps_category.FormattingEnabled = true;
            this.sp_ps_category.Location = new System.Drawing.Point(369, 10);
            this.sp_ps_category.Name = "sp_ps_category";
            this.sp_ps_category.Size = new System.Drawing.Size(195, 21);
            this.sp_ps_category.TabIndex = 17;
            this.sp_ps_category.SelectedValueChanged += new System.EventHandler(this.sp_ps_category_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sp_Subcategories);
            this.groupBox2.Location = new System.Drawing.Point(8, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 372);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubCategory";
            // 
            // sp_Subcategories
            // 
            this.sp_Subcategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Subcategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subcategory,
            this.SubcategoryDescription});
            this.sp_Subcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Subcategories.Location = new System.Drawing.Point(3, 17);
            this.sp_Subcategories.Name = "sp_Subcategories";
            this.sp_Subcategories.RowHeadersWidth = 20;
            this.sp_Subcategories.RowTemplate.Height = 23;
            this.sp_Subcategories.Size = new System.Drawing.Size(553, 352);
            this.sp_Subcategories.TabIndex = 4;
            // 
            // Subcategory
            // 
            this.Subcategory.FillWeight = 50.76142F;
            this.Subcategory.HeaderText = "Subcategory";
            this.Subcategory.Name = "Subcategory";
            // 
            // SubcategoryDescription
            // 
            this.SubcategoryDescription.FillWeight = 149.2386F;
            this.SubcategoryDescription.HeaderText = "Description";
            this.SubcategoryDescription.Name = "SubcategoryDescription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product";
            // 
            // sp_ps_product
            // 
            this.sp_ps_product.FormattingEnabled = true;
            this.sp_ps_product.Location = new System.Drawing.Point(61, 10);
            this.sp_ps_product.Name = "sp_ps_product";
            this.sp_ps_product.Size = new System.Drawing.Size(195, 21);
            this.sp_ps_product.TabIndex = 14;
            this.sp_ps_product.SelectedValueChanged += new System.EventHandler(this.sp_ps_product_SelectedValueChanged);
            // 
            // tabPage_ProductCategories
            // 
            this.tabPage_ProductCategories.CausesValidation = false;
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
            this.tabPage_ProductCategories.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_ProductCategories.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sp_Categories);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 372);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // sp_Categories
            // 
            this.sp_Categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.CategoryDescription});
            this.sp_Categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Categories.Location = new System.Drawing.Point(3, 17);
            this.sp_Categories.Name = "sp_Categories";
            this.sp_Categories.RowHeadersWidth = 20;
            this.sp_Categories.RowTemplate.Height = 23;
            this.sp_Categories.Size = new System.Drawing.Size(553, 352);
            this.sp_Categories.TabIndex = 4;
            // 
            // Category
            // 
            this.Category.FillWeight = 50.76142F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.FillWeight = 149.2386F;
            this.CategoryDescription.HeaderText = "Description";
            this.CategoryDescription.Name = "CategoryDescription";
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
            this.sp_pc_Product.Tag = "";
            this.sp_pc_Product.SelectedValueChanged += new System.EventHandler(this.sp_pc_Product_SelectedValueChanged);
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
            this.tabPage_Product.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_Product.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // sp_Product
            // 
            this.sp_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.ProductDescription});
            this.sp_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Product.Location = new System.Drawing.Point(3, 3);
            this.sp_Product.Name = "sp_Product";
            this.sp_Product.RowHeadersWidth = 20;
            this.sp_Product.RowTemplate.Height = 23;
            this.sp_Product.Size = new System.Drawing.Size(569, 411);
            this.sp_Product.TabIndex = 3;
            // 
            // Product
            // 
            this.Product.FillWeight = 50.76142F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // ProductDescription
            // 
            this.ProductDescription.FillWeight = 149.2386F;
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.Name = "ProductDescription";
            // 
            // sp_SpecyficationsTab
            // 
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_Product);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_ProductCategories);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_SubCategory);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_Collections);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_Theme);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_Component);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_Part);
            this.sp_SpecyficationsTab.Controls.Add(this.tabPage_License);
            this.sp_SpecyficationsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_SpecyficationsTab.Location = new System.Drawing.Point(0, 0);
            this.sp_SpecyficationsTab.Name = "sp_SpecyficationsTab";
            this.sp_SpecyficationsTab.SelectedIndex = 0;
            this.sp_SpecyficationsTab.Size = new System.Drawing.Size(583, 443);
            this.sp_SpecyficationsTab.TabIndex = 0;
            this.sp_SpecyficationsTab.Enter += new System.EventHandler(this.sp_SpecyficationsTab_Enter);
            // 
            // tabPage_Theme
            // 
            this.tabPage_Theme.Controls.Add(this.sp_Themes);
            this.tabPage_Theme.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Theme.Name = "tabPage_Theme";
            this.tabPage_Theme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Theme.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Theme.TabIndex = 8;
            this.tabPage_Theme.Text = "Themes";
            this.tabPage_Theme.UseVisualStyleBackColor = true;
            this.tabPage_Theme.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_Theme.Enter += new System.EventHandler(this.tabPage_Enter);
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
            this.tabPage_Component.TabIndex = 9;
            this.tabPage_Component.Text = "Component Categories";
            this.tabPage_Component.UseVisualStyleBackColor = true;
            this.tabPage_Component.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_Component.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // sp_ComponentsCategories
            // 
            this.sp_ComponentsCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_ComponentsCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentCategory,
            this.ComponentDescription});
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
            // ComponentDescription
            // 
            this.ComponentDescription.FillWeight = 149.2386F;
            this.ComponentDescription.HeaderText = "Description";
            this.ComponentDescription.Name = "ComponentDescription";
            // 
            // tabPage_Part
            // 
            this.tabPage_Part.Controls.Add(this.sp_Parts);
            this.tabPage_Part.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Part.Name = "tabPage_Part";
            this.tabPage_Part.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Part.Size = new System.Drawing.Size(575, 417);
            this.tabPage_Part.TabIndex = 10;
            this.tabPage_Part.Text = "Part Classes";
            this.tabPage_Part.UseVisualStyleBackColor = true;
            this.tabPage_Part.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_Part.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // sp_Parts
            // 
            this.sp_Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartClass,
            this.MaterialDescription});
            this.sp_Parts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Parts.Location = new System.Drawing.Point(3, 3);
            this.sp_Parts.Name = "sp_Parts";
            this.sp_Parts.RowHeadersWidth = 20;
            this.sp_Parts.RowTemplate.Height = 23;
            this.sp_Parts.Size = new System.Drawing.Size(569, 411);
            this.sp_Parts.TabIndex = 3;
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
            // tabPage_License
            // 
            this.tabPage_License.Controls.Add(this.sp_License);
            this.tabPage_License.Location = new System.Drawing.Point(4, 22);
            this.tabPage_License.Name = "tabPage_License";
            this.tabPage_License.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_License.Size = new System.Drawing.Size(575, 417);
            this.tabPage_License.TabIndex = 11;
            this.tabPage_License.Text = "License";
            this.tabPage_License.UseVisualStyleBackColor = true;
            this.tabPage_License.Leave += new System.EventHandler(this.tabPage_Leave);
            this.tabPage_License.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // sp_License
            // 
            this.sp_License.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_License.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.LicenseDescription});
            this.sp_License.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_License.Location = new System.Drawing.Point(3, 3);
            this.sp_License.Name = "sp_License";
            this.sp_License.RowHeadersWidth = 20;
            this.sp_License.RowTemplate.Height = 23;
            this.sp_License.Size = new System.Drawing.Size(569, 411);
            this.sp_License.TabIndex = 4;
            // 
            // License
            // 
            this.License.FillWeight = 50.76142F;
            this.License.HeaderText = "License";
            this.License.Name = "License";
            // 
            // LicenseDescription
            // 
            this.LicenseDescription.FillWeight = 149.2386F;
            this.LicenseDescription.HeaderText = "Description";
            this.LicenseDescription.Name = "LicenseDescription";
            // 
            // Specifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(583, 443);
            this.Controls.Add(this.sp_SpecyficationsTab);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 470);
            this.Name = "Specifications";
            this.Text = "Specifications";
            this.tabPage_Collections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Collections)).EndInit();
            this.tabPage_SubCategory.ResumeLayout(false);
            this.tabPage_SubCategory.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Subcategories)).EndInit();
            this.tabPage_ProductCategories.ResumeLayout(false);
            this.tabPage_ProductCategories.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Categories)).EndInit();
            this.tabPage_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).EndInit();
            this.sp_SpecyficationsTab.ResumeLayout(false);
            this.tabPage_Theme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Themes)).EndInit();
            this.tabPage_Component.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComponentsCategories)).EndInit();
            this.tabPage_Part.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Parts)).EndInit();
            this.tabPage_License.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_License)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_Collections;
        private System.Windows.Forms.DataGridView sp_Collections;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionDescription;
        private System.Windows.Forms.TabPage tabPage_SubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sp_ps_category;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView sp_Subcategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sp_ps_product;
        private System.Windows.Forms.TabPage tabPage_ProductCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView sp_Categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sp_pc_Product;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.DataGridView sp_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.TabControl sp_SpecyficationsTab;
        private System.Windows.Forms.TabPage tabPage_Theme;
        private System.Windows.Forms.DataGridView sp_Themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThemeDescription;
        private System.Windows.Forms.TabPage tabPage_Component;
        private System.Windows.Forms.DataGridView sp_ComponentsCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentDescription;
        private System.Windows.Forms.TabPage tabPage_Part;
        private System.Windows.Forms.DataGridView sp_Parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcategoryDescription;
        private System.Windows.Forms.TabPage tabPage_License;
        private System.Windows.Forms.DataGridView sp_License;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseDescription;

    }
}