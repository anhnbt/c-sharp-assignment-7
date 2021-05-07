
namespace Assignment_7
{
    partial class FrmProductList
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
            this.lblProductList = new System.Windows.Forms.Label();
            this.dgvwProductList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblYouAreSelected = new System.Windows.Forms.Label();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.ForeColor = System.Drawing.Color.Navy;
            this.lblProductList.Location = new System.Drawing.Point(343, 9);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(126, 25);
            this.lblProductList.TabIndex = 0;
            this.lblProductList.Text = "Product List";
            // 
            // dgvwProductList
            // 
            this.dgvwProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ImagePath,
            this.Selected});
            this.dgvwProductList.Location = new System.Drawing.Point(16, 58);
            this.dgvwProductList.Name = "dgvwProductList";
            this.dgvwProductList.Size = new System.Drawing.Size(772, 150);
            this.dgvwProductList.TabIndex = 1;
            this.dgvwProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvwProductList_CellFormatting);
            this.dgvwProductList.Click += new System.EventHandler(this.dgvwProductList_Click);
            this.dgvwProductList.DoubleClick += new System.EventHandler(this.dgvwProductList_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblYouAreSelected
            // 
            this.lblYouAreSelected.AutoSize = true;
            this.lblYouAreSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYouAreSelected.Location = new System.Drawing.Point(12, 420);
            this.lblYouAreSelected.Name = "lblYouAreSelected";
            this.lblYouAreSelected.Size = new System.Drawing.Size(146, 13);
            this.lblYouAreSelected.TabIndex = 3;
            this.lblYouAreSelected.Text = "You\'re selected: ProductID = ";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelectedItem.Location = new System.Drawing.Point(154, 420);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedItem.TabIndex = 4;
            this.lblSelectedItem.Text = "0";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "Đường dẫn ảnh";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Width = 200;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "Chọn";
            this.Selected.Name = "Selected";
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.lblYouAreSelected);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvwProductList);
            this.Controls.Add(this.lblProductList);
            this.Name = "FrmProductList";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dgvwProductList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblYouAreSelected;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selected;
    }
}