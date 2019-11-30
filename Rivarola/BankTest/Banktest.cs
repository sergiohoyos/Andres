using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void debitocuandoesmenosque0()
        {
           
            double BalanceInicial = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("yeyo", BalanceInicial);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}