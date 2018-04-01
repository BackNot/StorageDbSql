using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form_ChooseItem : Form
    {
        StorageDbContext context;
        public Item selectedItem = null;
        public bool IsDoneClicked = false; // check if user has clicked the DONE button

        public Form_ChooseItem()
        {
            InitializeComponent();

        }

        private void Form_ChooseItem_Load(object sender, EventArgs e)
        {
            context = new StorageDbContext();

            this.itemsTableAdapter.Fill(this.storageDbDataSet.Items);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


        }

        private void btn_DoneSelected_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                int itemId = int.Parse(row.Cells[0].Value.ToString()); // get the item id marked for selling

                selectedItem = (from entity in context.Items
                                where entity.ItemId == itemId
                                select entity).SingleOrDefault();

            }
            IsDoneClicked = true;
            this.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
