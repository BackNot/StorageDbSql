namespace Storage
{
    partial class Form_ChooseItem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageDbDataSet = new Storage.StorageDbDataSet();
            this.itemsTableAdapter = new Storage.StorageDbDataSetTableAdapters.ItemsTableAdapter();
            this.btn_DoneSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 135);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 150;
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
            // btn_DoneSelected
            // 
            this.btn_DoneSelected.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_DoneSelected.Location = new System.Drawing.Point(532, 180);
            this.btn_DoneSelected.Name = "btn_DoneSelected";
            this.btn_DoneSelected.Size = new System.Drawing.Size(75, 23);
            this.btn_DoneSelected.TabIndex = 1;
            this.btn_DoneSelected.Text = "Done";
            this.btn_DoneSelected.UseVisualStyleBackColor = true;
            this.btn_DoneSelected.Click += new System.EventHandler(this.btn_DoneSelected_Click);
            // 
            // Form_ChooseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 215);
            this.Controls.Add(this.btn_DoneSelected);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ChooseItem";
            this.Text = "Choose item";
            this.Load += new System.EventHandler(this.Form_ChooseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StorageDbDataSet storageDbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StorageDbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button btn_DoneSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
    }
}