using NUnit.Framework;
using Prototip_projet2;

namespace Prototip_Projet2__test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Clients Gertrude = new Clients("Gertrude", 1234);
            Accounts GAccount = new Accounts(Gertrude);
            GAccount.SetAmount(1000);
            Transaction.Withdraw(GAccount, 500);
            Assert.AreEqual(500, GAccount.GetAmount());
        }

        [Test]
        public void Test2()
        {
            Clients Gertrude = new Clients("Gertrude", 1234);
            Accounts GAccount = new Accounts(Gertrude);
            GAccount.SetAmount(1000);
            Accounts GsavingAccount = new Accounts(Gertrude);
            Transaction.MoneyTransfer(GAccount, GsavingAccount, 100);

            Assert.AreEqual(900, GAccount.GetAmount());
            Assert.AreEqual(100, GsavingAccount.GetAmount());
        }
    }
}