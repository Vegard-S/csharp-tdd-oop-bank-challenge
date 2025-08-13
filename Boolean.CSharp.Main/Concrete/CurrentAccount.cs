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
        private decimal _overdraft {  get; set; }

        private bool _overdraftAllowed { get; set; }

        public override void CreateAccount(Branches branches)
        {
            throw new NotImplementedException();
        }

        public bool RequestOverdraft(decimal ammount)
        {
            throw new NotImplementedException();
        }
        public bool OverdraftRseponse(bool answer)
        {
            throw new NotImplementedException();
        }

    }
}
