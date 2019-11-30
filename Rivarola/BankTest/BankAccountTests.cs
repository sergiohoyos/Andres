using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void DebitoConBalanceCorrecto()
        {
            
            double BalanceInicial = 11.99;
            double Debito = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("yeyo", BalanceInicial);

            
            account.Debit(Debito);

            
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Cuenta debitada no correctamente");
        }
    }
}
