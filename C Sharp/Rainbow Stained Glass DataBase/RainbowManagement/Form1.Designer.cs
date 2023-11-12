namespace RainbowManagement
{
    partial class Form1
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
            this.sp_Product = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Product
            // 
            this.sp_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Description});
            this.sp_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_Product.Location = new System.Drawing.Point(0, 0);
            this.sp_Product.Name = "sp_Product";
            this.sp_Product.RowHeadersWidth = 20;
            this.sp_Product.RowTemplate.Height = 23;
            this.sp_Product.Size = new System.Drawing.Size(526, 411);
            this.sp_Product.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.sp_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sp_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sp_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}