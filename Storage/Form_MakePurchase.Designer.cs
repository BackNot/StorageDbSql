namespace Storage
{
    partial class Form_MakePurchase
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.storageDbDataSet = new Storage.StorageDbDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Storage.StorageDbDataSetTableAdapters.ItemsTableAdapter();
            this.btn_SelectItem = new System.Windows.Forms.Button();
            this.txt_SelectedItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CustomerPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ClearCart = new System.Windows.Forms.Button();
            this.btn_DeleteCustHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select item to sell";
            // 
            // storageDbDataSet
            // 
            this.storageDbDataSet.DataSetName = "StorageDbDataSet";
            this.storageDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.storageDbDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_SelectItem
            // 
            this.btn_SelectItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_SelectItem.Location = new System.Drawing.Point(12, 41);
            this.btn_SelectItem.Name = "btn_SelectItem";
            this.btn_SelectItem.Size = new System.Drawing.Size(89, 23);
            this.btn_SelectItem.TabIndex = 1;
            this.btn_SelectItem.Text = "Select Item";
            this.btn_SelectItem.UseVisualStyleBackColor = true;
            this.btn_SelectItem.Click += new System.EventHandler(this.btn_SelectItem_Click);
            // 
            // txt_SelectedItem
            // 
            this.txt_SelectedItem.Location = new System.Drawing.Point(123, 43);
            this.txt_SelectedItem.Name = "txt_SelectedItem";
            this.txt_SelectedItem.Size = new System.Drawing.Size(135, 20);
            this.txt_SelectedItem.TabIndex = 2;
            this.txt_SelectedItem.TextChanged += new System.EventHandler(this.txt_SelectedItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How much quantity:";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(123, 86);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 4;
            // 
            // btn_Sell
            // 
            this.btn_Sell.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_Sell.Location = new System.Drawing.Point(15, 209);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(56, 38);
            this.btn_Sell.TabIndex = 5;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer\'s name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer\'s adress:";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(535, 42);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerName.TabIndex = 8;
            this.txt_CustomerName.TextChanged += new System.EventHandler(this.txt_CustomerName_TextChanged);
            // 
            // txt_CustomerAdress
            // 
            this.txt_CustomerAdress.Location = new System.Drawing.Point(535, 117);
            this.txt_CustomerAdress.Name = "txt_CustomerAdress";
            this.txt_CustomerAdress.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerAdress.TabIndex = 9;
            this.txt_CustomerAdress.TextChanged += new System.EventHandler(this.txt_CustomerAdress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer\'s phone:";
            // 
            // txt_CustomerPhone
            // 
            this.txt_CustomerPhone.Location = new System.Drawing.Point(535, 79);
            this.txt_CustomerPhone.Name = "txt_CustomerPhone";
            this.txt_CustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerPhone.TabIndex = 11;
            this.txt_CustomerPhone.TextChanged += new System.EventHandler(this.txt_CustomerPhone_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button1.Location = new System.Drawing.Point(491, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "See this customer\'s history";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_AddToCart.Location = new System.Drawing.Point(145, 117);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(75, 45);
            this.btn_AddToCart.TabIndex = 13;
            this.btn_AddToCart.Text = "Add to cart";
            this.btn_AddToCart.UseVisualStyleBackColor = true;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(226, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 82);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cart:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(379, 241);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(34, 13);
            this.lbl_Total.TabIndex = 16;
            this.lbl_Total.Text = "Total:";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Location = new System.Drawing.Point(419, 241);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(28, 13);
            this.lbl_totalPrice.TabIndex = 17;
            this.lbl_totalPrice.Text = "0,00";
            this.lbl_totalPrice.Click += new System.EventHandler(this.lbl_totalPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Selected item:";
            // 
            // btn_ClearCart
            // 
            this.btn_ClearCart.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_ClearCart.Location = new System.Drawing.Point(145, 168);
            this.btn_ClearCart.Name = "btn_ClearCart";
            this.btn_ClearCart.Size = new System.Drawing.Size(75, 39);
            this.btn_ClearCart.TabIndex = 20;
            this.btn_ClearCart.Text = "Clear cart";
            this.btn_ClearCart.UseVisualStyleBackColor = true;
            this.btn_ClearCart.Click += new System.EventHandler(this.btn_ClearCart_Click);
            // 
            // btn_DeleteCustHistory
            // 
            this.btn_DeleteCustHistory.Location = new System.Drawing.Point(492, 183);
            this.btn_DeleteCustHistory.Name = "btn_DeleteCustHistory";
            this.btn_DeleteCustHistory.Size = new System.Drawing.Size(157, 37);
            this.btn_DeleteCustHistory.TabIndex = 21;
            this.btn_DeleteCustHistory.Text = "Delete all history ";
            this.btn_DeleteCustHistory.UseVisualStyleBackColor = true;
            this.btn_DeleteCustHistory.Click += new System.EventHandler(this.btn_DeleteCustHistory_Click);
            // 
            // Form_MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 259);
            this.Controls.Add(this.btn_DeleteCustHistory);
            this.Controls.Add(this.btn_ClearCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CustomerPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CustomerAdress);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SelectedItem);
            this.Controls.Add(this.btn_SelectItem);
            this.Controls.Add(this.label1);
            this.Name = "Form_MakePurchase";
            this.Text = "Make purchase";
            this.Load += new System.EventHandler(this.Form_MakePurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StorageDbDataSet storageDbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StorageDbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button btn_SelectItem;
        private System.Windows.Forms.TextBox txt_SelectedItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_CustomerAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CustomerPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ClearCart;
        private System.Windows.Forms.Button btn_DeleteCustHistory;

    }
}