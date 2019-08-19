using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate_Classes
{
    public class Customer
    {
        //these need to be initialized separately in the constructors so that class instances have access to the properties
        public int Id;
        public string Name;
        //public List<Order> Orders;
        public List<Order> Orders = new List<Order>();
        //readonly List<Order> Orders = new List<Order>(); //readonly makes sure that Orders is initialized only once right here for safety reasons


        //Constructor overload is used in order to have multiple constructors that can take different initializing parameters
        public Customer()
        {
            //Orders = new List<Order>(); *having line 13 removes this line*
        }

        public Customer(int id)
            :this() //this makes sure that the first constructor runs first to initialize the 'Orders = new List<Order>()' step
        {
            this.Id = id;   //constructor for primitive type values are not necessary and can be excluded
        }

        public Customer(int id, string name)
            :this(id) //this makes sure that the constructor with the 'id' parameter is invoked so that the previous two constructors are all invoked
        {
            this.Name = name; //constructor for primitive type values are not necessary and can be excluded
        }

        public void Promote()
        {
            Orders = new List<Order>();
            //having Orders be readonly prevents it from being initialized again 
        }
    }

    public class Order
    { 
    }
}
