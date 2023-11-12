namespace RainbowStainedGlass
{
    partial class ComponentSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentSettings));
            this.tab_ComponentSettings = new System.Windows.Forms.TabControl();
            this.tab_ComponentsPart = new System.Windows.Forms.TabPage();
            this.cs_ComponentParts = new System.Windows.Forms.DataGridView();
            this.ComponentPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentPartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_ComponentConfig = new System.Windows.Forms.TabPage();
            this.cs_ProductPartList = new System.Windows.Forms.ListBox();
            this.cs_ConfigGrid = new System.Windows.Forms.DataGridView();
            this.cs_ComponentPart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cs_ComponentName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tab_ComponentSettings.SuspendLayout();
            this.tab_ComponentsPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cs_ComponentParts)).BeginInit();
            this.tab_ComponentConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cs_ConfigGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ComponentSettings
            // 
            this.tab_ComponentSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_ComponentSettings.Controls.Add(this.tab_ComponentsPart);
            this.tab_ComponentSettings.Controls.Add(this.tab_ComponentConfig);
            this.tab_ComponentSettings.Location = new System.Drawing.Point(13, 12);
            this.tab_ComponentSettings.Name = "tab_ComponentSettings";
            this.tab_ComponentSettings.SelectedIndex = 0;
            this.tab_ComponentSettings.Size = new System.Drawing.Size(557, 439);
            this.tab_ComponentSettings.TabIndex = 0;
            // 
            // tab_ComponentsPart
            // 
            this.tab_ComponentsPart.Controls.Add(this.cs_ComponentParts);
            this.tab_ComponentsPart.Location = new System.Drawing.Point(4, 22);
            this.tab_ComponentsPart.Name = "tab_ComponentsPart";
            this.tab_ComponentsPart.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ComponentsPart.Size = new System.Drawing.Size(549, 413);
            this.tab_ComponentsPart.TabIndex = 0;
            this.tab_ComponentsPart.Text = "Parts of Components";
            this.tab_ComponentsPart.UseVisualStyleBackColor = true;
            this.tab_ComponentsPart.Leave += new System.EventHandler(this.tab_ComponentsPart_Leave);
            this.tab_ComponentsPart.Enter += new System.EventHandler(this.tab_ComponentsPart_Enter);
            // 
            // cs_ComponentParts
            // 
            this.cs_ComponentParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cs_ComponentParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentPart,
            this.ComponentPartDescription});
            this.cs_ComponentParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cs_ComponentParts.Location = new System.Drawing.Point(3, 3);
            this.cs_ComponentParts.Name = "cs_ComponentParts";
            this.cs_ComponentParts.RowHeadersWidth = 20;
            this.cs_ComponentParts.RowTemplate.Height = 20;
            this.cs_ComponentParts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cs_ComponentParts.Size = new System.Drawing.Size(543, 407);
            this.cs_ComponentParts.TabIndex = 6;
            // 
            // ComponentPart
            // 
            this.ComponentPart.DataPropertyName = "ComponentPart";
            this.ComponentPart.FillWeight = 50.76142F;
            this.ComponentPart.HeaderText = "Part Name";
            this.ComponentPart.Name = "ComponentPart";
            // 
            // ComponentPartDescription
            // 
            this.ComponentPartDescription.DataPropertyName = "ComponentPartDescription";
            this.ComponentPartDescription.FillWeight = 149.2386F;
            this.ComponentPartDescription.HeaderText = "Description";
            this.ComponentPartDescription.Name = "ComponentPartDescription";
            // 
            // tab_ComponentConfig
            // 
            this.tab_ComponentConfig.Controls.Add(this.cs_ProductPartList);
            this.tab_ComponentConfig.Controls.Add(this.cs_ConfigGrid);
            this.tab_ComponentConfig.Location = new System.Drawing.Point(4, 22);
            this.tab_ComponentConfig.Name = "tab_ComponentConfig";
            this.tab_ComponentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ComponentConfig.Size = new System.Drawing.Size(549, 413);
            this.tab_ComponentConfig.TabIndex = 1;
            this.tab_ComponentConfig.Text = "Configuration";
            this.tab_ComponentConfig.UseVisualStyleBackColor = true;
            this.tab_ComponentConfig.Enter += new System.EventHandler(this.tab_ComponentConfig_Enter);
            // 
            // cs_ProductPartList
            // 
            this.cs_ProductPartList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.cs_ProductPartList.FormattingEnabled = true;
            this.cs_ProductPartList.Location = new System.Drawing.Point(6, 6);
            this.cs_ProductPartList.Name = "cs_ProductPartList";
            this.cs_ProductPartList.Size = new System.Drawing.Size(181, 407);
            this.cs_ProductPartList.TabIndex = 8;
            this.cs_ProductPartList.SelectedValueChanged += new System.EventHandler(this.cs_ProductPartList_SelectedValueChanged);
            // 
            // cs_ConfigGrid
            // 
            this.cs_ConfigGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cs_ConfigGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cs_ConfigGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cs_ComponentPart,
            this.cs_ComponentName});
            this.cs_ConfigGrid.Location = new System.Drawing.Point(193, 6);
            this.cs_ConfigGrid.Name = "cs_ConfigGrid";
            this.cs_ConfigGrid.RowHeadersWidth = 20;
            this.cs_ConfigGrid.RowTemplate.Height = 20;
            this.cs_ConfigGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cs_ConfigGrid.Size = new System.Drawing.Size(353, 407);
            this.cs_ConfigGrid.TabIndex = 7;
            this.cs_ConfigGrid.Leave += new System.EventHandler(this.cs_ConfigGrid_Leave);
            this.cs_ConfigGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.cs_ConfigGrid_DataError);
            // 
            // cs_ComponentPart
            // 
            this.cs_ComponentPart.DataPropertyName = "ComponentPart";
            this.cs_ComponentPart.FillWeight = 50F;
            this.cs_ComponentPart.HeaderText = "Component Part";
            this.cs_ComponentPart.Name = "cs_ComponentPart";
            this.cs_ComponentPart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cs_ComponentPart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cs_ComponentName
            // 
            this.cs_ComponentName.DataPropertyName = "ComponentID";
            this.cs_ComponentName.FillWeight = 50F;
            this.cs_ComponentName.HeaderText = "Component Name";
            this.cs_ComponentName.Name = "cs_ComponentName";
            this.cs_ComponentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cs_ComponentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ComponentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 463);
            this.Controls.Add(this.tab_ComponentSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComponentSettings";
            this.Text = "ComponentSettings";
            this.tab_ComponentSettings.ResumeLayout(false);
            this.tab_ComponentsPart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cs_ComponentParts)).EndInit();
            this.tab_ComponentConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cs_ConfigGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ComponentSettings;
        private System.Windows.Forms.TabPage tab_ComponentsPart;
        private System.Windows.Forms.DataGridView cs_ComponentParts;
        private System.Windows.Forms.TabPage tab_ComponentConfig;
        private System.Windows.Forms.DataGridView cs_ConfigGrid;
        private System.Windows.Forms.ListBox cs_ProductPartList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentPartDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn cs_ComponentPart;
        private System.Windows.Forms.DataGridViewComboBoxColumn cs_ComponentName;
    }
}