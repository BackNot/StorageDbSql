using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
  public  class Purchase
    {
      public Purchase()
      {

      }
      public Purchase(DateTime PurchaseDateTime , Customer customer , ICollection<Item> Items)
      {
          this.PurchaseDateTime = PurchaseDateTime;
          this.Customer = customer;
          this.Items = Items;
      }
      public int PurchaseId { get; set; }
      public DateTime PurchaseDateTime { get; set; }
      public Customer Customer { get; set; }
      public ICollection<Item> Items { get; set; }
    }
}
