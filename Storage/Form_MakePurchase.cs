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
    public partial class Form_MakePurchase : Form
    {
        StorageDbContext context;
        Form_ChooseItem form_chooseItem;
        Item chosenItem = null; // selected item
        List<Item> itemsToSell; // items marked for selling 
        List<Item> entitiesToDelete; // entities that are bought and are no longer needed in the DB
        Dictionary<int, int> itemsInStock; // item ID is key and item quantity as value . It checks if we have more quantity from that item



        public void PopulateItemsInStockDictionary(Dictionary<int, int> itemsInStock) // populate the dictionary with all the items in the DB
        {
            itemsInStock.Clear(); // Clear it if there's anything inside
            foreach (var item in context.Items)
            {
                itemsInStock.Add(item.ItemId, item.ItemQuantity);
            }
        }
        public Form_MakePurchase()
        {
            InitializeComponent();


        }

        private void Form_MakePurchase_Load(object sender, EventArgs e)
        {
            context = new StorageDbContext();
            itemsToSell = new List<Item>();
            itemsInStock = new Dictionary<int, int>();
            entitiesToDelete = new List<Item>();

            PopulateItemsInStockDictionary(itemsInStock); // fill the dictionary
            txt_SelectedItem.ReadOnly = true;
            this.itemsTableAdapter.Fill(this.storageDbDataSet.Items);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


        }

        private void btn_SelectItem_Click(object sender, EventArgs e)
        {


            form_chooseItem = new Form_ChooseItem();
            form_chooseItem.ShowDialog();
            chosenItem = form_chooseItem.selectedItem; // selected item from the form
            if (form_chooseItem.IsDoneClicked == true) // if false then user has clicked the X and we don't need to make the check below
                if (chosenItem != null)
                {

                    txt_SelectedItem.Text = "ID:" + chosenItem.ItemId + " Name: " + chosenItem.ItemName + " Quantity: " + chosenItem.ItemQuantity;
                }


        }

        private void txt_SelectedItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            Item itemToDelete = null;
            string customerName = txt_CustomerName.Text;
            string customerPhone = txt_CustomerPhone.Text;
            string customerAddress = txt_CustomerAdress.Text;
            var customerHistory = (from cust in context.Customers // Go and find the customer with those data in the DB
                                   where cust.CustomerName == customerName &&
                                    cust.CustomerPhone == customerPhone
                                   select cust).SingleOrDefault();
            if ((customerName.Length <= 2) || (customerPhone.Length <= 3) || (customerAddress.Length <= 3)) MessageBox.Show("Enter more details about the customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                StringBuilder output = new StringBuilder("Customer info: \n Name:  " + txt_CustomerName.Text
                    + "   Phone: " + txt_CustomerPhone.Text +
                    " \t Adress: " + txt_CustomerAdress.Text + " \n \n Items: \n  ");
                foreach (var item in listBox1.Items)
                {
                    output.Append(item + "\n ");
                }
                output.Append("\n \t \t \t \t TOTAL: " + Convert.ToDecimal(lbl_totalPrice.Text) + " \n");

                DialogResult result = MessageBox.Show(
                output.ToString(), "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    foreach (KeyValuePair<int, int> item in itemsInStock)
                    {
                        foreach (Item itemInStock in context.Items)
                        {
                            if (item.Key == itemInStock.ItemId)
                                itemsToSell.Add(itemInStock);
                        }
                        // Item that has quantity 0 in the dictionary (out of stock) is going to be deleted from the database.
                        if (item.Value == 0)
                        {
                            itemToDelete = (from x in context.Items where x.ItemId == item.Key select x).Single();
                            entitiesToDelete.Add(itemToDelete); // add the item on the list for deletion 
                        }

                    }
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Purchase purchase = new Purchase(DateTime.Now, customerHistory, itemsToSell);
                    context.Purchases.Add(purchase);

                    if (customerHistory == null) // new client
                    {
                        List<Purchase> purchases = new List<Purchase>();
                        purchases.Add(purchase);
                        Customer customer = new Customer(txt_CustomerName.Text, txt_CustomerAdress.Text, txt_CustomerPhone.Text, purchases);
                        context.Customers.Add(customer);
                    }
                    else // old client just add another purchase
                    {
                        customerHistory.Purchases.Add(purchase);
                    }

                }

                context.Items.RemoveRange(entitiesToDelete); // all the items that are out of stock to be deleted from the DB
                context.SaveChanges();
                // clear the listbox and set the label to zero again
                listBox1.Items.Clear();
                lbl_totalPrice.Text = "0,00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { // Show customer history based on name and phone
            string customerName = txt_CustomerName.Text;
            string customerPhone = txt_CustomerPhone.Text;
            string customerAddress = txt_CustomerAdress.Text;
            var customerHistory = (from cust in context.Customers
                                   where cust.CustomerName == customerName &&
                                   cust.CustomerPhone == customerPhone

                                   select cust).SingleOrDefault();
            if (customerHistory != null)
            {
                MessageBox.Show("This customer has made " + customerHistory.Purchases.Count.ToString() + " purchases so far", "Old customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There is no history about this customer", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {

            try
            {

                int value;
                if (int.Parse(txt_Quantity.Text) == 0) throw new FormatException(); // if user enter 0 as a quantity 
                if (itemsInStock.TryGetValue(chosenItem.ItemId, out value))
                {
                    if (value < 0) MessageBox.Show("There is no such quantity from that item left.", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (int.Parse(txt_Quantity.Text) > value) MessageBox.Show("There is no such quantity from that item left.", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        itemsInStock[chosenItem.ItemId] = value - int.Parse(txt_Quantity.Text);
                        // everything is OK
                        chosenItem.ItemQuantity -= int.Parse(txt_Quantity.Text);
                        listBox1.Items.Add("ID:" + chosenItem.ItemId.ToString() + ", Name:" + chosenItem.ItemName + ", Price: " +
                           chosenItem.ItemPrice + ", Quantity: " + txt_Quantity.Text);
                        lbl_totalPrice.Text = (Convert.ToDecimal(lbl_totalPrice.Text) + (chosenItem.ItemPrice * int.Parse(txt_Quantity.Text))).ToString(); // add to the Total label
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a correct number for quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the textboxes and set the selected item back to null
            txt_SelectedItem.Clear();
            txt_Quantity.Clear();
            chosenItem = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_ClearCart_Click(object sender, EventArgs e)
        {

            PopulateItemsInStockDictionary(itemsInStock); // fill the dictionary again
            entitiesToDelete.Clear(); // theres no entities for deletion now
            listBox1.Items.Clear();
            lbl_totalPrice.Text = "0,00";
        }

        private void txt_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CustomerAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteCustHistory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete all history for purchases and customers?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {

                context.Purchases.RemoveRange(context.Purchases.ToList());
                context.Customers.RemoveRange(context.Customers.ToList());
                context.SaveChanges();
                MessageBox.Show("All history is cleared.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }


    }
}
