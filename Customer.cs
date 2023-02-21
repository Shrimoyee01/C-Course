using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<OrderBase> Orders;      // store objects of type order in this list

        public Customer()       // default and paramaterless constructor
        {
            Orders = new List<OrderBase>();     // initialise the order list
        }
        public Customer(int id) 
            : this()
        { this.Id = id; }

        public Customer(int id, string name) 
            : this(id)     // Constructor that takes an id parameter
        {
            this.Name = name;
        }
    }
}
