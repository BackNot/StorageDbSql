namespace Storage
{
    partial class Form_AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_ItemDescription = new System.Windows.Forms.TextBox();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ItemQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item description:";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(102, 49);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemName.TabIndex = 3;
            // 
            // txt_ItemDescription
            // 
            this.txt_ItemDescription.Location = new System.Drawing.Point(102, 75);
            this.txt_ItemDescription.Name = "txt_ItemDescription";
            this.txt_ItemDescription.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemDescription.TabIndex = 4;
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(102, 101);
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemPrice.TabIndex = 5;
            this.txt_ItemPrice.TextChanged += new System.EventHandler(this.txt_ItemPrice_TextChanged);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_AddItem.Location = new System.Drawing.Point(102, 166);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddItem.TabIndex = 6;
            this.btn_AddItem.Text = "Add";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item quantity:";
            // 
            // txt_ItemQuantity
            // 
            this.txt_ItemQuantity.Location = new System.Drawing.Point(102, 127);
            this.txt_ItemQuantity.Name = "txt_ItemQuantity";
            this.txt_ItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemQuantity.TabIndex = 8;
            // 
            // Form_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 211);
            this.Controls.Add(this.txt_ItemQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.txt_ItemPrice);
            this.Controls.Add(this.txt_ItemDescription);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddItem";
            this.Text = "Add item";
            this.Load += new System.EventHandler(this.Form_AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.TextBox txt_ItemDescription;
        private System.Windows.Forms.TextBox txt_ItemPrice;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ItemQuantity;
    }
}