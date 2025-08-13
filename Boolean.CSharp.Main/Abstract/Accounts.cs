using Boolean.CSharp.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Abstract
{
    public abstract class Accounts
    {
        private List<Payment> _transactionHistory = new List<Payment>();

        private decimal _balance { get; set; } = Decimal.Zero;
        public Branches _branches { get; set; }

        public virtual void CreateAccount(Branches branches)
        {
            throw new NotImplementedException();
        }
        
        public string Generatebankstatement()
        {
            throw new NotImplementedException();
        }

        public bool DepositFunds(decimal ammount)
        {
            throw new NotImplementedException();
        }

        public bool WithdrawFunds(decimal ammount)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateBalance()
        {
            throw new NotImplementedException();
        }

       public bool SendSms()
       {
            throw new NotImplementedException();
       }



    }
}
