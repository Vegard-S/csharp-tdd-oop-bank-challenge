using Boolean.CSharp.Main.Abstract;
using Boolean.CSharp.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Concrete
{
    public class CurrentAccount : Accounts
    {
        public decimal _overdraft {  get; set; }

        public bool _overdraftAllowed { get; set; }

        public CurrentAccount(Branches bransh, decimal overdraft)
        {
            _branches = bransh;
            _overdraft = overdraft;
        }

        public override bool WithdrawFunds(decimal ammount)
        {
            if (CalculateBalance() > ammount)
            {
                Payment payment = new Payment(0, ammount);
                _transactionHistory.Add(payment);
                return true;
            }
            else if (CalculateBalance() + _overdraft > ammount && _overdraftAllowed)
            {
                Payment payment = new Payment(0, ammount);
                _transactionHistory.Add(payment);
                Console.WriteLine("you are overdrafting your account");
                return true;
            }
            else
            {
                Console.WriteLine("you are trying to withdraw more than you have!");
                return false;
            }
        }

        public bool RequestOverdraft(decimal ammount)
        {
            if (ammount >= 0)
            {
                _overdraft = ammount;
                return true;
            }
            else 
            { 
                Console.WriteLine("need positiv decimal");
                return false; 
            }
            
        }
        public bool OverdraftRseponse(bool answer)
        {
            if (answer)
            {
                _overdraftAllowed = true;
                return true;
            }
            else
            {
                _overdraftAllowed = false;
                return false;
            }
        }

    }
}
