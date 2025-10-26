using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Dollar
    {
        private decimal amount; // to use this private amount we shall use public method to call it
        public decimal _amount // proberety to use private amount and validation it with value
        {
            //encapsulation
            get { return this.amount; }
            // validation
            //set
            //{
            //    this.amount = preocessvalue(value);
            //}

            // we can prevent user to enter a value by making private set and make a proberety method to enter value 
            private set
            {
                this.amount = preocessvalue(value);
            }
        }
        public void setamount(decimal value) {  amount = value; } //a proberety method to enter value
        public bool iszero => amount == 0;

        // Property And Initialization
        public decimal ConversionFactor { get; set; } = 1.99m; //impossible to store any data inside
        // // ex
        //ConversionFactor = 12.12m  i tried but it's not readable by compiler

        public Dollar()
        {
                
        }
        public Dollar(decimal amount)
        {
            this.amount = preocessvalue(amount);
            //if (amount <= 0) {  amount = 0; }
        }
        private decimal preocessvalue(decimal value) => value <= 0 ? 0 : Math.Round(value, 4);  // proberety to safe code.....math.around return value with the first (4 decimal numbers) 
    }

    // get is already a method in form publci decimal getvalue (decimal v) { return v;} 
    // set is already a method in form publci void setvalue (decimal v) { this.amount = v;}
}
