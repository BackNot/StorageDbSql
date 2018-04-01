namespace Storage
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
            this.components = new System.ComponentModel.Container();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_MakePurchase = new System.Windows.Forms.Button();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageDbDataSet = new Storage.StorageDbDataSet();
            this.itemsTableAdapter = new Storage.StorageDbDataSetTableAdapters.ItemsTableAdapter();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_AddItem.Location = new System.Drawing.Point(12, 56);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddItem.TabIndex = 0;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_MakePurchase
            // 
            this.btn_MakePurchase.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_MakePurchase.Location = new System.Drawing.Point(116, 214);
            this.btn_MakePurchase.Name = "btn_MakePurchase";
            this.btn_MakePurchase.Size = new System.Drawing.Size(75, 43);
            this.btn_MakePurchase.TabIndex = 1;
            this.btn_MakePurchase.Text = "Make purchase";
            this.btn_MakePurchase.UseVisualStyleBackColor = true;
            this.btn_MakePurchase.Click += new System.EventHandler(this.btn_MakePurchase_Click);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_RemoveItem.Location = new System.Drawing.Point(12, 85);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(75, 40);
            this.btn_RemoveItem.TabIndex = 2;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(116, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.storageDbDataSet;
            // 
            // storageDbDataSet
            // 
            this.storageDbDataSet.DataSetName = "StorageDbDataSet";
            this.storageDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeleteAll.Location = new System.Drawing.Point(12, 131);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(75, 34);
            this.btn_DeleteAll.TabIndex = 5;
            this.btn_DeleteAll.Text = "Delete all items";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 269);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_RemoveItem);
            this.Controls.Add(this.btn_MakePurchase);
            this.Controls.Add(this.btn_AddItem);
            this.Name = "Form1";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_MakePurchase;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StorageDbDataSet storageDbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StorageDbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;

    }
}

