using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TickerSeller
    {
        private string name;
        private double price = 100.0;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        private bool isChildren;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Ticket Class");
            Console.WriteLine("Childrens will always get a 75% discount!");
            Console.WriteLine();
              
            ReadInput();
            CalculateAmountToPay();
            ShowResults();
        }
        private void ReadInput()
        {
            Console.WriteLine("Hello, whats your name? ")
        }    
            
    }
}
