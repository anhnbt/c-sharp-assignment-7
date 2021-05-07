
namespace Assignment_7
{
    partial class FrmProductSelected
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
            this.picImagePath = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAvaiableProducts = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSelectedProducts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagePath)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImagePath
            // 
            this.picImagePath.Location = new System.Drawing.Point(12, 12);
            this.picImagePath.Name = "picImagePath";
            this.picImagePath.Size = new System.Drawing.Size(175, 300);
            this.picImagePath.TabIndex = 0;
            this.picImagePath.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAvaiableProducts);
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaiable Products";
            // 
            // lstAvaiableProducts
            // 
            this.lstAvaiableProducts.FormattingEnabled = true;
            this.lstAvaiableProducts.Location = new System.Drawing.Point(8, 21);
            this.lstAvaiableProducts.Name = "lstAvaiableProducts";
            this.lstAvaiableProducts.Size = new System.Drawing.Size(187, 264);
            this.lstAvaiableProducts.TabIndex = 0;
            this.lstAvaiableProducts.Click += new System.EventHandler(this.lstAvaiableProducts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSelectedProducts);
            this.groupBox2.Location = new System.Drawing.Point(453, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Products";
            // 
            // lstSelectedProducts
            // 
            this.lstSelectedProducts.FormattingEnabled = true;
            this.lstSelectedProducts.Location = new System.Drawing.Point(6, 19);
            this.lstSelectedProducts.Name = "lstSelectedProducts";
            this.lstSelectedProducts.Size = new System.Drawing.Size(187, 264);
            this.lstSelectedProducts.TabIndex = 0;
            this.lstSelectedProducts.Click += new System.EventHandler(this.lstSelectedProducts_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(399, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 115);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(400, 145);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(47, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // FrmProductSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 324);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImagePath);
            this.Name = "FrmProductSelected";
            this.Text = "Product Selected";
            this.Load += new System.EventHandler(this.FrmProductSelected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagePath)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstAvaiableProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSelectedProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShow;
    }
}