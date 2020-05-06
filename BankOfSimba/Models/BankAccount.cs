using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public bool King { get; set; }
        public bool GoodGuy { get; set; }

        public BankAccount(string name, decimal balance, string animalType, bool king, bool goodGuy)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            Currency = "zebras";
            King = king;
            GoodGuy = goodGuy;
       
        }
       



    }
}
