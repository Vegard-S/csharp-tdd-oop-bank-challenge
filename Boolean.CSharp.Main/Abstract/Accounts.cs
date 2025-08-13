using Boolean.CSharp.Main.Concrete;
using Boolean.CSharp.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;



namespace Boolean.CSharp.Main.Abstract
{
    public abstract class Accounts
    {
        private protected List<Payment> _transactionHistory = new List<Payment>();

        
        
        private protected Branches _branches { get; set; }

        

        public string Generatebankstatement()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append(string.Format("{0,10} || {1,10} || {2,10} || {3,10} \n", "Date", "Credit", "Debit", "Balance"));
            foreach (Payment payment in _transactionHistory.OrderByDescending(t => t.Date))
            {
                stringbuilder.Append(string.Format("{0,10} || {1,10} || {2,10} || {3,10} \n",
                        payment.Date.ToShortDateString(),
                        payment.Credit,
                        payment.Debit,
                        payment.Balance)
                        );
            };
            string result = stringbuilder.ToString();
            return result;
        }

        public bool DepositFunds(decimal ammount)
        {
            
            Payment payment = new Payment(ammount, 0);
            _transactionHistory.Add(payment);
            payment.Balance = CalculateBalance();

            if (payment.Credit == ammount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool WithdrawFunds(decimal ammount)
        {
            if (CalculateBalance() > ammount)
            {
                Payment payment = new Payment(0, ammount);
                _transactionHistory.Add(payment);
                payment.Balance = CalculateBalance();
                return true;
            }
            else
            {
                Console.WriteLine("you are trying to withdraw more than you have!");
                return false;
            }
        }

        public decimal CalculateBalance()
        {
            decimal result = 0;
            foreach (var item in _transactionHistory)
            {
                if (item.Credit != 0)
                {
                    result += item.Credit;
                }
                else if (item.Debit != 0)
                {
                    result -= item.Debit;
                }
                
            }
            return result;
        }

       
       public bool SendSms()
       {
            //twillio stuff
            //change true for if sent or something
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
       }



    }
}
