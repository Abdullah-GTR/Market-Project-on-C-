
namespace OOAD_Project
{
    partial class Form4
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
            this.SellingGrid1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlMart = new System.Windows.Forms.Panel();
            this.lblAmt = new System.Windows.Forms.Label();
            this.GridProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SellingGrid1)).BeginInit();
            this.pnlMart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // SellingGrid1
            // 
            this.SellingGrid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SellingGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellingGrid1.Location = new System.Drawing.Point(10, 226);
            this.SellingGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.SellingGrid1.Name = "SellingGrid1";
            this.SellingGrid1.RowHeadersWidth = 51;
            this.SellingGrid1.RowTemplate.Height = 24;
            this.SellingGrid1.Size = new System.Drawing.Size(897, 167);
            this.SellingGrid1.TabIndex = 6;
            this.SellingGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingGrid1_CellContentClick);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1004, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button4.Location = new System.Drawing.Point(377, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "Super Mart";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Grocery ",
            "Meat ",
            "Fruits ",
            "Vegitabels"});
            this.comboBox.Location = new System.Drawing.Point(10, 176);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(122, 27);
            this.comboBox.TabIndex = 4;
            this.comboBox.Text = "Select Catagory";
            // 
            // ProductName
            // 
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Enabled = false;
            this.ProductName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(90, 63);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(182, 17);
            this.ProductName.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductID.Enabled = false;
            this.ProductID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(90, 24);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(182, 17);
            this.ProductID.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Lavender;
            this.button10.Location = new System.Drawing.Point(160, 171);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 29);
            this.button10.TabIndex = 5;
            this.button10.Text = "Add Product";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(2, 57);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 29);
            this.button7.TabIndex = 2;
            this.button7.Text = "Name";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pnlMart
            // 
            this.pnlMart.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMart.Controls.Add(this.lblAmt);
            this.pnlMart.Controls.Add(this.GridProduct);
            this.pnlMart.Controls.Add(this.SellingGrid1);
            this.pnlMart.Controls.Add(this.ProductPrice);
            this.pnlMart.Controls.Add(this.comboBox);
            this.pnlMart.Controls.Add(this.ProductQuantity);
            this.pnlMart.Controls.Add(this.ProductName);
            this.pnlMart.Controls.Add(this.ProductID);
            this.pnlMart.Controls.Add(this.button1);
            this.pnlMart.Controls.Add(this.button10);
            this.pnlMart.Controls.Add(this.button9);
            this.pnlMart.Controls.Add(this.button8);
            this.pnlMart.Controls.Add(this.button7);
            this.pnlMart.Controls.Add(this.button6);
            this.pnlMart.Location = new System.Drawing.Point(38, 49);
            this.pnlMart.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMart.Name = "pnlMart";
            this.pnlMart.Size = new System.Drawing.Size(950, 413);
            this.pnlMart.TabIndex = 4;
            this.pnlMart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMart_Paint);
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmt.Location = new System.Drawing.Point(506, 200);
            this.lblAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(28, 19);
            this.lblAmt.TabIndex = 7;
            this.lblAmt.Text = "Rs";
            // 
            // GridProduct
            // 
            this.GridProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Price,
            this.Quantity,
            this.Catagory});
            this.GridProduct.Location = new System.Drawing.Point(298, 18);
            this.GridProduct.Margin = new System.Windows.Forms.Padding(2);
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.RowHeadersWidth = 51;
            this.GridProduct.RowTemplate.Height = 24;
            this.GridProduct.Size = new System.Drawing.Size(609, 167);
            this.GridProduct.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "Product ID";
            this.ID.Name = "ID";
            // 
            // PName
            // 
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Product Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Product Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Catagory
            // 
            this.Catagory.HeaderText = "Total Price";
            this.Catagory.Name = "Catagory";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPrice.Enabled = false;
            this.ProductPrice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.Location = new System.Drawing.Point(90, 139);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(182, 17);
            this.ProductPrice.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(400, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Total Amount ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(2, 132);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 29);
            this.button9.TabIndex = 2;
            this.button9.Text = "Price";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lavender;
            this.button8.Location = new System.Drawing.Point(2, 98);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Quantity";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Lavender;
            this.button6.Location = new System.Drawing.Point(2, 18);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "ID";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 31);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(948, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductQuantity.Enabled = false;
            this.ProductQuantity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.Location = new System.Drawing.Point(90, 105);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(182, 17);
            this.ProductQuantity.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pnlMart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingGrid1)).EndInit();
            this.pnlMart.ResumeLayout(false);
            this.pnlMart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SellingGrid1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnlMart;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView GridProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ProductQuantity;
    }
}