using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete;
using Boolean.CSharp.Main.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        [Test]
        public void CalculateBalance()
        {
            //arrange
            CurrentAccount account = new CurrentAccount(Branches.Oslo, 0);
            account.DepositFunds(1000m);

            //act
            account.WithdrawFunds(500m);
            decimal result = account.CalculateBalance();

            //assert
            Assert.That(result, Is.EqualTo(500m));
        }

        [Test]
        public void RequestOverdraft()
        {
            //arrange
            CurrentAccount account = new CurrentAccount(Branches.Oslo, 0);


            //act
            bool result1 = account.WithdrawFunds(499m);
            account.RequestOverdraft(500);
            account.OverdraftRseponse(true);
            bool result2 = account.WithdrawFunds(499m);



            //assert
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }

        [Test]
        public void OverdraftResponse()
        {
            //arrange
            CurrentAccount account = new CurrentAccount(Branches.Oslo, 0);


            //act
            
            bool result1 = account.WithdrawFunds(499m);
            account.RequestOverdraft(500);
            account.OverdraftRseponse(false);
            bool result2 = account.WithdrawFunds(499m);
            account.OverdraftRseponse(true);
            bool result3 = account.WithdrawFunds(499m);





            //assert
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }

        [Test]
        public void SendSMS()
        {
            CurrentAccount account = new CurrentAccount(Branches.Oslo, 0);


            //act
            bool result = account.SendSms();

            //assert
            Assert.IsTrue(result);
        }
    }
}
