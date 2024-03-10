
namespace OOAD_Project
{
    partial class Form3
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
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.btnPdelete = new System.Windows.Forms.Button();
            this.btnPedit = new System.Windows.Forms.Button();
            this.btnPadd = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.CustomerMail = new System.Windows.Forms.TextBox();
            this.btnCdelete = new System.Windows.Forms.Button();
            this.btnCedit = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.CustomerNumber = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlProduct.Controls.Add(this.Grid1);
            this.pnlProduct.Controls.Add(this.ProductPrice);
            this.pnlProduct.Controls.Add(this.button14);
            this.pnlProduct.Controls.Add(this.btnPdelete);
            this.pnlProduct.Controls.Add(this.btnPedit);
            this.pnlProduct.Controls.Add(this.btnPadd);
            this.pnlProduct.Controls.Add(this.comboBox);
            this.pnlProduct.Controls.Add(this.ProductQuantity);
            this.pnlProduct.Controls.Add(this.ProductName);
            this.pnlProduct.Controls.Add(this.txtSearch);
            this.pnlProduct.Controls.Add(this.ProductID);
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.button10);
            this.pnlProduct.Controls.Add(this.button9);
            this.pnlProduct.Controls.Add(this.button8);
            this.pnlProduct.Controls.Add(this.button7);
            this.pnlProduct.Controls.Add(this.button6);
            this.pnlProduct.Location = new System.Drawing.Point(9, 73);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(922, 390);
            this.pnlProduct.TabIndex = 0;
            this.pnlProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProduct_Paint);
            // 
            // Grid1
            // 
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(304, 84);
            this.Grid1.Margin = new System.Windows.Forms.Padding(2);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersWidth = 51;
            this.Grid1.RowTemplate.Height = 24;
            this.Grid1.Size = new System.Drawing.Size(603, 284);
            this.Grid1.TabIndex = 6;
            this.Grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellContentClick);
            // 
            // ProductPrice
            // 
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPrice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.Location = new System.Drawing.Point(90, 193);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(182, 17);
            this.ProductPrice.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Lavender;
            this.button14.Location = new System.Drawing.Point(787, 48);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(93, 32);
            this.button14.TabIndex = 11;
            this.button14.Text = "Refresh";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnPdelete
            // 
            this.btnPdelete.FlatAppearance.BorderSize = 0;
            this.btnPdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnPdelete.Location = new System.Drawing.Point(177, 285);
            this.btnPdelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdelete.Name = "btnPdelete";
            this.btnPdelete.Size = new System.Drawing.Size(80, 32);
            this.btnPdelete.TabIndex = 8;
            this.btnPdelete.Text = "Delete";
            this.btnPdelete.UseVisualStyleBackColor = true;
            this.btnPdelete.Click += new System.EventHandler(this.btnPdelete_Click);
            // 
            // btnPedit
            // 
            this.btnPedit.FlatAppearance.BorderSize = 0;
            this.btnPedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedit.ForeColor = System.Drawing.Color.Lavender;
            this.btnPedit.Location = new System.Drawing.Point(90, 285);
            this.btnPedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedit.Name = "btnPedit";
            this.btnPedit.Size = new System.Drawing.Size(62, 32);
            this.btnPedit.TabIndex = 7;
            this.btnPedit.Text = " Edit";
            this.btnPedit.UseVisualStyleBackColor = true;
            this.btnPedit.Click += new System.EventHandler(this.btnPedit_Click);
            // 
            // btnPadd
            // 
            this.btnPadd.FlatAppearance.BorderSize = 0;
            this.btnPadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadd.ForeColor = System.Drawing.Color.Lavender;
            this.btnPadd.Location = new System.Drawing.Point(17, 285);
            this.btnPadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPadd.Name = "btnPadd";
            this.btnPadd.Size = new System.Drawing.Size(86, 32);
            this.btnPadd.TabIndex = 6;
            this.btnPadd.Text = "Add";
            this.btnPadd.UseVisualStyleBackColor = true;
            this.btnPadd.Click += new System.EventHandler(this.button11_Click);
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
            this.comboBox.Location = new System.Drawing.Point(90, 232);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(183, 27);
            this.comboBox.TabIndex = 5;
            this.comboBox.Text = "Select Catagory";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductQuantity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.Location = new System.Drawing.Point(90, 157);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(182, 17);
            this.ProductQuantity.TabIndex = 3;
            // 
            // ProductName
            // 
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(90, 119);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(182, 17);
            this.ProductName.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(600, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 17);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ProductID
            // 
            this.ProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(90, 84);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(182, 17);
            this.ProductID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Product ";
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Lavender;
            this.button10.Location = new System.Drawing.Point(2, 228);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 29);
            this.button10.TabIndex = 2;
            this.button10.Text = "Catagory";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(2, 187);
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
            this.button8.Location = new System.Drawing.Point(2, 150);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Quantity";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(2, 112);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 29);
            this.button7.TabIndex = 2;
            this.button7.Text = "Name";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Lavender;
            this.button6.Location = new System.Drawing.Point(2, 78);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "ID";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlCustomer.Controls.Add(this.Grid2);
            this.pnlCustomer.Controls.Add(this.CustomerMail);
            this.pnlCustomer.Controls.Add(this.btnCdelete);
            this.pnlCustomer.Controls.Add(this.btnCedit);
            this.pnlCustomer.Controls.Add(this.button18);
            this.pnlCustomer.Controls.Add(this.CustomerNumber);
            this.pnlCustomer.Controls.Add(this.CustomerName);
            this.pnlCustomer.Controls.Add(this.CustomerID);
            this.pnlCustomer.Controls.Add(this.label2);
            this.pnlCustomer.Controls.Add(this.button20);
            this.pnlCustomer.Controls.Add(this.button21);
            this.pnlCustomer.Controls.Add(this.button22);
            this.pnlCustomer.Controls.Add(this.button23);
            this.pnlCustomer.Location = new System.Drawing.Point(9, 75);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(925, 390);
            this.pnlCustomer.TabIndex = 0;
            this.pnlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomer_Paint);
            // 
            // Grid2
            // 
            this.Grid2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Location = new System.Drawing.Point(304, 84);
            this.Grid2.Margin = new System.Windows.Forms.Padding(2);
            this.Grid2.Name = "Grid2";
            this.Grid2.RowHeadersWidth = 51;
            this.Grid2.RowTemplate.Height = 24;
            this.Grid2.Size = new System.Drawing.Size(603, 284);
            this.Grid2.TabIndex = 6;
            this.Grid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid2_CellContentClick);
            // 
            // CustomerMail
            // 
            this.CustomerMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerMail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMail.Location = new System.Drawing.Point(88, 200);
            this.CustomerMail.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerMail.Name = "CustomerMail";
            this.CustomerMail.Size = new System.Drawing.Size(182, 17);
            this.CustomerMail.TabIndex = 3;
            this.CustomerMail.TextChanged += new System.EventHandler(this.CustomerMail_TextChanged);
            // 
            // btnCdelete
            // 
            this.btnCdelete.FlatAppearance.BorderSize = 0;
            this.btnCdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnCdelete.Location = new System.Drawing.Point(175, 244);
            this.btnCdelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCdelete.Name = "btnCdelete";
            this.btnCdelete.Size = new System.Drawing.Size(80, 32);
            this.btnCdelete.TabIndex = 6;
            this.btnCdelete.Text = "Delete";
            this.btnCdelete.UseVisualStyleBackColor = true;
            this.btnCdelete.Click += new System.EventHandler(this.btnCdelete_Click_1);
            // 
            // btnCedit
            // 
            this.btnCedit.FlatAppearance.BorderSize = 0;
            this.btnCedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCedit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCedit.ForeColor = System.Drawing.Color.Lavender;
            this.btnCedit.Location = new System.Drawing.Point(88, 244);
            this.btnCedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCedit.Name = "btnCedit";
            this.btnCedit.Size = new System.Drawing.Size(62, 32);
            this.btnCedit.TabIndex = 5;
            this.btnCedit.Text = " Edit";
            this.btnCedit.UseVisualStyleBackColor = true;
            this.btnCedit.Click += new System.EventHandler(this.btnCedit_Click_1);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Lavender;
            this.button18.Location = new System.Drawing.Point(15, 244);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(86, 32);
            this.button18.TabIndex = 4;
            this.button18.Text = "Add";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNumber.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNumber.Location = new System.Drawing.Point(90, 157);
            this.CustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(182, 17);
            this.CustomerNumber.TabIndex = 2;
            // 
            // CustomerName
            // 
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(90, 119);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(182, 17);
            this.CustomerName.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(90, 84);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(182, 17);
            this.CustomerID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Customer";
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Lavender;
            this.button20.Location = new System.Drawing.Point(0, 193);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 29);
            this.button20.TabIndex = 2;
            this.button20.Text = "Email";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.Lavender;
            this.button21.Location = new System.Drawing.Point(2, 150);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 29);
            this.button21.TabIndex = 2;
            this.button21.Text = "Number";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.Lavender;
            this.button22.Location = new System.Drawing.Point(2, 112);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 29);
            this.button22.TabIndex = 2;
            this.button22.Text = "Name";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Lavender;
            this.button23.Location = new System.Drawing.Point(2, 78);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 29);
            this.button23.TabIndex = 2;
            this.button23.Text = "ID";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(58, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(220, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button4.Location = new System.Drawing.Point(538, 28);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(905, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 472);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnPdelete;
        private System.Windows.Forms.Button btnPedit;
        private System.Windows.Forms.Button btnPadd;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.TextBox CustomerMail;
        private System.Windows.Forms.Button btnCdelete;
        private System.Windows.Forms.Button btnCedit;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox CustomerNumber;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox txtSearch;
    }
}