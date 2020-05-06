using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccountsList
    {
        public List<BankAccount> BankAccounts { get; set; }

        public BankAccountsList()
        {
            BankAccounts = CreateAccountsList();
        }
        static List<BankAccount> CreateAccountsList()
        {

           var list = new List<BankAccount>();
         list.Add(new BankAccount("Simba", 2000.00m, "lion",true,true));
         list.Add(new BankAccount("Timon", 2.00m, "meerkat",false,true));
         list.Add(new BankAccount("Pumba", 5.00m, "warthog",true,true));
         list.Add(new BankAccount("Shenzi", 100.00m, "hyena",false,false));
         list.Add(new BankAccount("Rafiki", 500.00m, "mandril",false,false));

            return list;
        }
    
    
    }



}
