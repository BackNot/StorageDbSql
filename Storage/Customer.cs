using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
   public class Customer
    {
       public Customer()
       {

       }
       public Customer(string CustomerName,string CustomerAdress,string CustomerPhone,ICollection<Purchase> Purchases)
       {
           this.CustomerName = CustomerName;
           this.CustomerPhone = CustomerPhone;
           this.CustomerAdress = CustomerAdress;
           this.Purchases = Purchases;
       }
       public int CustomerId { get; set; }

       public string CustomerAdress { get; set; }

       public string CustomerName { get; set; }

       public string CustomerPhone { get; set; }

       public virtual ICollection<Purchase> Purchases { get; set; }
   }
}
