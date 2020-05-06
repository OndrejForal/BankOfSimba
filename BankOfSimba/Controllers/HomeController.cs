using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {

        static List<BankAccount> bankAccounts = new List<BankAccount>();
        public HomeController()
        {
            var bank = new BankAccountsList();
            if (!bankAccounts.Any())
            {
                bankAccounts = bank.BankAccounts;

            }
          
        }
        
        [HttpGet("show")]
        public IActionResult Show()
        {
            var simba = new BankAccount("Simba", 2000.00m, "lion",true,true);
            
            return View(simba) ;
        }
        [HttpGet("print")]

        public IActionResult PrintString()
        {
            var model = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View(model as object);
        }

        [HttpGet("animal")]

        public IActionResult PrintAllAnimalsAccounts()
        {
            
            return View(bankAccounts);
        }
        [HttpGet("animal-index")]
        public IActionResult PrintAllAnimalsAccountsWithIndex()
        {
            return View();
        }
        [HttpPost("raise")]
        public IActionResult RaiseBalance()
        { 
            foreach (var animal in bankAccounts)
            {
                if (animal.King)
                {
                    animal.Balance += 100;
                }
                else
                {
                    animal.Balance += 10;
                }
            }

            return RedirectToAction("PrintAllAnimalsAccounts","Home");
        }
    }
}