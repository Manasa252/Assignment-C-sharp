using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Product
    {
        public String Name { get; set; }

        public virtual void Dispense() { }
    }
    
    class Snack: Product
    {
        public Snack()
        {
            this.Name = "Snack";
        }
        public override void Dispense()
        {
            Console.WriteLine("Snack dispensed");
        }
    }
    class Beverage : Product
    {
        public Beverage()
        {
            this.Name = "Beverage";
        }
        public override void Dispense()
        {
            Console.WriteLine("Beverage dispensed");
        }
    }
    interface IVendingMachine
    {
        void SelectProduct(Product product);
    }
    class VendingMachine:IVendingMachine
    {
        public void SelectProduct(Product product)
        {
            product.Dispense();
        }
    }
   
}
