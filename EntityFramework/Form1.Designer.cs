namespace EntityFramework
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.gbx_updateProduct = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_updateStockAmount = new System.Windows.Forms.TextBox();
            this.lbl_updateStockAmount = new System.Windows.Forms.Label();
            this.txt_updateUnitPrice = new System.Windows.Forms.TextBox();
            this.lbl_updateUnitPrice = new System.Windows.Forms.Label();
            this.txt_updateName = new System.Windows.Forms.TextBox();
            this.lbl_updateName = new System.Windows.Forms.Label();
            this.gbx_addProduct = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_stockAmount = new System.Windows.Forms.TextBox();
            this.lbl_stockAmount = new System.Windows.Forms.Label();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.gbx_updateProduct.SuspendLayout();
            this.gbx_addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(513, 397);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete Product";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // gbx_updateProduct
            // 
            this.gbx_updateProduct.Controls.Add(this.btn_update);
            this.gbx_updateProduct.Controls.Add(this.txt_updateStockAmount);
            this.gbx_updateProduct.Controls.Add(this.lbl_updateStockAmount);
            this.gbx_updateProduct.Controls.Add(this.txt_updateUnitPrice);
            this.gbx_updateProduct.Controls.Add(this.lbl_updateUnitPrice);
            this.gbx_updateProduct.Controls.Add(this.txt_updateName);
            this.gbx_updateProduct.Controls.Add(this.lbl_updateName);
            this.gbx_updateProduct.Location = new System.Drawing.Point(254, 287);
            this.gbx_updateProduct.Name = "gbx_updateProduct";
            this.gbx_updateProduct.Size = new System.Drawing.Size(226, 139);
            this.gbx_updateProduct.TabIndex = 12;
            this.gbx_updateProduct.TabStop = false;
            this.gbx_updateProduct.Text = "Update a product";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(88, 110);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update Product";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_updateStockAmount
            // 
            this.txt_updateStockAmount.Location = new System.Drawing.Point(88, 86);
            this.txt_updateStockAmount.Name = "txt_updateStockAmount";
            this.txt_updateStockAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_updateStockAmount.TabIndex = 6;
            // 
            // lbl_updateStockAmount
            // 
            this.lbl_updateStockAmount.AutoSize = true;
            this.lbl_updateStockAmount.Location = new System.Drawing.Point(10, 89);
            this.lbl_updateStockAmount.Name = "lbl_updateStockAmount";
            this.lbl_updateStockAmount.Size = new System.Drawing.Size(74, 13);
            this.lbl_updateStockAmount.TabIndex = 5;
            this.lbl_updateStockAmount.Text = "Stock Amount";
            // 
            // txt_updateUnitPrice
            // 
            this.txt_updateUnitPrice.Location = new System.Drawing.Point(88, 58);
            this.txt_updateUnitPrice.Name = "txt_updateUnitPrice";
            this.txt_updateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_updateUnitPrice.TabIndex = 4;
            // 
            // lbl_updateUnitPrice
            // 
            this.lbl_updateUnitPrice.AutoSize = true;
            this.lbl_updateUnitPrice.Location = new System.Drawing.Point(10, 61);
            this.lbl_updateUnitPrice.Name = "lbl_updateUnitPrice";
            this.lbl_updateUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lbl_updateUnitPrice.TabIndex = 3;
            this.lbl_updateUnitPrice.Text = "Unit Price";
            this.lbl_updateUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_updateName
            // 
            this.txt_updateName.Location = new System.Drawing.Point(88, 29);
            this.txt_updateName.Name = "txt_updateName";
            this.txt_updateName.Size = new System.Drawing.Size(100, 20);
            this.txt_updateName.TabIndex = 2;
            // 
            // lbl_updateName
            // 
            this.lbl_updateName.AutoSize = true;
            this.lbl_updateName.Location = new System.Drawing.Point(10, 32);
            this.lbl_updateName.Name = "lbl_updateName";
            this.lbl_updateName.Size = new System.Drawing.Size(35, 13);
            this.lbl_updateName.TabIndex = 1;
            this.lbl_updateName.Text = "Name";
            // 
            // gbx_addProduct
            // 
            this.gbx_addProduct.Controls.Add(this.btn_add);
            this.gbx_addProduct.Controls.Add(this.txt_stockAmount);
            this.gbx_addProduct.Controls.Add(this.lbl_stockAmount);
            this.gbx_addProduct.Controls.Add(this.txt_unitPrice);
            this.gbx_addProduct.Controls.Add(this.lbl_unitPrice);
            this.gbx_addProduct.Controls.Add(this.txt_name);
            this.gbx_addProduct.Controls.Add(this.lbl_name);
            this.gbx_addProduct.Location = new System.Drawing.Point(12, 287);
            this.gbx_addProduct.Name = "gbx_addProduct";
            this.gbx_addProduct.Size = new System.Drawing.Size(226, 139);
            this.gbx_addProduct.TabIndex = 11;
            this.gbx_addProduct.TabStop = false;
            this.gbx_addProduct.Text = "Add a product";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(88, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Product";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_stockAmount
            // 
            this.txt_stockAmount.Location = new System.Drawing.Point(88, 86);
            this.txt_stockAmount.Name = "txt_stockAmount";
            this.txt_stockAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_stockAmount.TabIndex = 6;
            // 
            // lbl_stockAmount
            // 
            this.lbl_stockAmount.AutoSize = true;
            this.lbl_stockAmount.Location = new System.Drawing.Point(10, 89);
            this.lbl_stockAmount.Name = "lbl_stockAmount";
            this.lbl_stockAmount.Size = new System.Drawing.Size(74, 13);
            this.lbl_stockAmount.TabIndex = 5;
            this.lbl_stockAmount.Text = "Stock Amount";
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(88, 58);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_unitPrice.TabIndex = 4;
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Location = new System.Drawing.Point(10, 61);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(53, 13);
            this.lbl_unitPrice.TabIndex = 3;
            this.lbl_unitPrice.Text = "Unit Price";
            this.lbl_unitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(88, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(10, 32);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // dgv_products
            // 
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(12, 24);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(776, 257);
            this.dgv_products.TabIndex = 10;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(513, 316);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 20);
            this.txt_search.TabIndex = 14;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(510, 300);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(80, 13);
            this.lbl_search.TabIndex = 15;
            this.lbl_search.Text = "Search product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.gbx_updateProduct);
            this.Controls.Add(this.gbx_addProduct);
            this.Controls.Add(this.dgv_products);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_updateProduct.ResumeLayout(false);
            this.gbx_updateProduct.PerformLayout();
            this.gbx_addProduct.ResumeLayout(false);
            this.gbx_addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox gbx_updateProduct;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_updateStockAmount;
        private System.Windows.Forms.Label lbl_updateStockAmount;
        private System.Windows.Forms.TextBox txt_updateUnitPrice;
        private System.Windows.Forms.Label lbl_updateUnitPrice;
        private System.Windows.Forms.TextBox txt_updateName;
        private System.Windows.Forms.Label lbl_updateName;
        private System.Windows.Forms.GroupBox gbx_addProduct;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_stockAmount;
        private System.Windows.Forms.Label lbl_stockAmount;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
    }
}

