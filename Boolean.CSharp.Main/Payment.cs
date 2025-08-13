using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public decimal Credit { get; set; }

        public decimal Debit { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public decimal Balance { get; set; }

        public Payment(decimal credit, decimal debit)
        {
            
            Credit = credit;
            Debit = debit;
            
            
        }
    }
}
