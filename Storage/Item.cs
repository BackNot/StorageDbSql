using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage
{
   public class Item
    {
       public Item()
       {

       }
       public Item(int ItemQuantity , decimal ItemPrice , string ItemName,string ItemDescription)
       {
           this.ItemQuantity = ItemQuantity;
           this.ItemPrice = ItemPrice;
           this.ItemName = ItemName;
           this.ItemDescription = ItemDescription;
       }
       
       public int ItemId { get; set; }
       public int ItemQuantity { get; set; }

       public decimal ItemPrice { get; set; }
       public string ItemName { get; set; }
       public string ItemDescription { get; set; }

       

    }
}
