namespace RainbowStainedGlass
{
    partial class DesignSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignSettings));
            this.tab_designsettings = new System.Windows.Forms.TabControl();
            this.tab_license = new System.Windows.Forms.TabPage();
            this.ds_License = new System.Windows.Forms.DataGridView();
            this.tab_maunfacturing = new System.Windows.Forms.TabPage();
            this.ds_Manufacturing = new System.Windows.Forms.DataGridView();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_designsettings.SuspendLayout();
            this.tab_license.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_License)).BeginInit();
            this.tab_maunfacturing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Manufacturing)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_designsettings
            // 
            this.tab_designsettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_designsettings.Controls.Add(this.tab_license);
            this.tab_designsettings.Controls.Add(this.tab_maunfacturing);
            this.tab_designsettings.Location = new System.Drawing.Point(12, 12);
            this.tab_designsettings.Name = "tab_designsettings";
            this.tab_designsettings.SelectedIndex = 0;
            this.tab_designsettings.Size = new System.Drawing.Size(558, 439);
            this.tab_designsettings.TabIndex = 0;
            this.tab_designsettings.Enter += new System.EventHandler(this.tab_designsettings_Enter);
            // 
            // tab_license
            // 
            this.tab_license.Controls.Add(this.ds_License);
            this.tab_license.Location = new System.Drawing.Point(4, 22);
            this.tab_license.Name = "tab_license";
            this.tab_license.Padding = new System.Windows.Forms.Padding(3);
            this.tab_license.Size = new System.Drawing.Size(550, 413);
            this.tab_license.TabIndex = 0;
            this.tab_license.Text = "Licenses";
            this.tab_license.UseVisualStyleBackColor = true;
            this.tab_license.Leave += new System.EventHandler(this.tab_DesignSettings_Leave);
            this.tab_license.Enter += new System.EventHandler(this.tab_license_Enter);
            // 
            // ds_License
            // 
            this.ds_License.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ds_License.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License,
            this.LicenseDescription});
            this.ds_License.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds_License.Location = new System.Drawing.Point(3, 3);
            this.ds_License.Name = "ds_License";
            this.ds_License.RowHeadersWidth = 20;
            this.ds_License.RowTemplate.Height = 23;
            this.ds_License.Size = new System.Drawing.Size(544, 407);
            this.ds_License.TabIndex = 5;
            // 
            // tab_maunfacturing
            // 
            this.tab_maunfacturing.Controls.Add(this.ds_Manufacturing);
            this.tab_maunfacturing.Location = new System.Drawing.Point(4, 22);
            this.tab_maunfacturing.Name = "tab_maunfacturing";
            this.tab_maunfacturing.Padding = new System.Windows.Forms.Padding(3);
            this.tab_maunfacturing.Size = new System.Drawing.Size(550, 413);
            this.tab_maunfacturing.TabIndex = 1;
            this.tab_maunfacturing.Text = "Manufacturing";
            this.tab_maunfacturing.UseVisualStyleBackColor = true;
            this.tab_maunfacturing.Leave += new System.EventHandler(this.tab_DesignSettings_Leave);
            this.tab_maunfacturing.Enter += new System.EventHandler(this.tab_maunfacturing_Enter);
            // 
            // ds_Manufacturing
            // 
            this.ds_Manufacturing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ds_Manufacturing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameter,
            this.Value});
            this.ds_Manufacturing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds_Manufacturing.Location = new System.Drawing.Point(3, 3);
            this.ds_Manufacturing.Name = "ds_Manufacturing";
            this.ds_Manufacturing.RowHeadersWidth = 20;
            this.ds_Manufacturing.RowTemplate.Height = 23;
            this.ds_Manufacturing.Size = new System.Drawing.Size(544, 407);
            this.ds_Manufacturing.TabIndex = 5;
            // 
            // License
            // 
            this.License.DataPropertyName = "License";
            this.License.FillWeight = 50.76142F;
            this.License.HeaderText = "License";
            this.License.Name = "License";
            // 
            // LicenseDescription
            // 
            this.LicenseDescription.DataPropertyName = "LicenseDescription";
            this.LicenseDescription.FillWeight = 149.2386F;
            this.LicenseDescription.HeaderText = "Description";
            this.LicenseDescription.Name = "LicenseDescription";
            // 
            // Parameter
            // 
            this.Parameter.DataPropertyName = "Parameter";
            this.Parameter.FillWeight = 140F;
            this.Parameter.HeaderText = "Parameter";
            this.Parameter.Name = "Parameter";
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.FillWeight = 149.2386F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // DesignSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 463);
            this.Controls.Add(this.tab_designsettings);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesignSettings";
            this.Text = "DesignSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesignSettings_FormClosing);
            this.tab_designsettings.ResumeLayout(false);
            this.tab_license.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_License)).EndInit();
            this.tab_maunfacturing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Manufacturing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_designsettings;
        private System.Windows.Forms.TabPage tab_license;
        private System.Windows.Forms.TabPage tab_maunfacturing;
        private System.Windows.Forms.DataGridView ds_License;
        private System.Windows.Forms.DataGridView ds_Manufacturing;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}