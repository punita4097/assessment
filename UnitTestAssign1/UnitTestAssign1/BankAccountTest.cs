using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;
using Sample;


namespace UnitTestAssign1
{
    [TestClass]
    public class BankAccountTest
    {

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 1200;
            double debitAmount = 450;
            double expected = 750;
            double loadFactor = 0.001;
            BankAccount account = new BankAccount("Punita", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, loadFactor, "Account not debited correctly");
        }


        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 1200;
            double debitAmount = -10000.00;
            BankAccount account = new BankAccount("Punita", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsNotGreaterThanThreeThousand_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 8000;
            double debitAmount = 5500;
            BankAccount account = new BankAccount("Punita", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

    }
}
