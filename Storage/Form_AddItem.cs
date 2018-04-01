using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form_AddItem : Form
    {

        StorageDbContext context = new StorageDbContext();
        public Form_AddItem()
        {
            InitializeComponent();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {

            try
            {
                Item item = new Item(int.Parse(txt_ItemQuantity.Text), Convert.ToDecimal(txt_ItemPrice.Text), txt_ItemName.Text, txt_ItemDescription.Text);
                context.Items.Add(item);
                context.SaveChanges();
                MessageBox.Show("Item has been added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter correct price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form_AddItem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void txt_ItemPrice_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
