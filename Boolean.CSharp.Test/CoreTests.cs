using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete;
using Boolean.CSharp.Main.Enums;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void CreateCurrentAccount()
        {
            //arrange
            
            //act
            CurrentAccount account = new CurrentAccount(Branches.Oslo, 0);
            

            //assert
            Assert.IsNotNull(account);

        }
        
        [Test]
        public void CreateSavingsAccount()
        {
            //arrange

            //act
            SavingsAccount account = new SavingsAccount(Branches.Oslo);
            

            //assert
            Assert.IsNotNull(account);
        }

        [Test]
        public void GenerateBankStatement()
        {
            //arrange
            SavingsAccount account = new SavingsAccount(Branches.Oslo);
            account.DepositFunds(1000m);
            
            //act
            string result = account.Generatebankstatement();
            Console.WriteLine(result);
            //assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DepositFunds()
        {
            //arrange
            SavingsAccount account = new SavingsAccount(Branches.Oslo);

            //act
            account.DepositFunds(1000m);
            decimal result = account.CalculateBalance();

            //assert
            Assert.That(result, Is.EqualTo(1000m));
        }

        [Test]
        public void WithdrawFunds()
        {
            //arrange
            SavingsAccount account = new SavingsAccount(Branches.Oslo);
            account.DepositFunds(1000m);

            //act
            account.WithdrawFunds(500m);
            decimal result = account.CalculateBalance();

            //assert
            Assert.That(result, Is.EqualTo(500m));
        }




    }
}