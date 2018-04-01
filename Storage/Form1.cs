using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Storage
{

    public partial class Form1 : Form
    {

        StorageDbContext context;

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new StorageDbContext();

            this.itemsTableAdapter.Fill(this.storageDbDataSet.Items);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            Form_AddItem form_AddItem = new Form_AddItem();
            form_AddItem.ShowDialog();
            this.itemsTableAdapter.Fill(this.storageDbDataSet.Items); // refresh the datagrid

        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            int deletedRows = 0;


            if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to delete the selected item?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        deletedRows++;
                        int itemId = int.Parse(row.Cells[0].Value.ToString()); // get the item id marked for deletion

                        var entityToDelete = (from entity in context.Items
                                              where entity.ItemId == itemId
                                              select entity).SingleOrDefault();
                        dataGridView1.Rows.RemoveAt(row.Index);
                        context.Items.Remove(entityToDelete);
                        context.SaveChanges();

                    }
            }
            if (deletedRows == 1)
                MessageBox.Show("The record has been removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (deletedRows > 1)
                MessageBox.Show("The records have been removed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete all items in the database?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                Thread.CurrentThread.IsBackground = true;
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Items");
                MessageBox.Show("The records have been deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.itemsTableAdapter.Fill(this.storageDbDataSet.Items); // refresh the datagrid
            }
        }

        private void btn_MakePurchase_Click(object sender, EventArgs e)
        {
            Form_MakePurchase form_madePurchase = new Form_MakePurchase();
            form_madePurchase.ShowDialog();
            this.itemsTableAdapter.Fill(this.storageDbDataSet.Items);
        }
    }
}

