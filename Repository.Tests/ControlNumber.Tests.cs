using System;
using Repository.Models;
using NUnit.Framework;


namespace Repository.Tests
{
    [TestFixture]
    public class ControlNumberTests
    {
        [Test]
        [TestCase("PL123456111000011")]
        [TestCase("PL1")]
        [TestCase("PL123456111000011")]
        [TestCase("PL005194416731")]
        [TestCase("PL005219782772")]
        [TestCase("PL005219784213")]
        [TestCase("PL005219784334")]
        [TestCase("PL005220562375")]
        public void CheckControlDigit_SetsIncorectString_ReturnFalse(string input)
        {
           // string input = "123456111000011";
            Cattle cattle = new Cattle() { CattleID = input };
            bool result = cattle.CheckControlDigit();
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("PL005194416736")]
        [TestCase("PL005219782778")]
        [TestCase("PL005219784215")]
        [TestCase("PL005219784338")]
        [TestCase("PL005220562376")]
        [TestCase("PL005224490736")]
        [TestCase("PL005224492013")]
        [TestCase("PL005224492099")]
        [TestCase("PL005224492334")]
        [TestCase("PL005224679117")]
        public void CheckControlDigit_SetCorrectValue_ReturnTrue(string input)
        {
            Cattle cattle = new Cattle() { CattleID=input };
            bool result = cattle.CheckControlDigit();
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("031693293")]
        [TestCase("029501691")]
        public void CheckHertControlDigit_SetCorrectValue_ReturnTrue(string hertId)
        {
            bool result = ControlNumber.CheckHertControlDigit(hertId);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("DE392445")]
        [TestCase("ES20345622")]
        [TestCase("GB200033224")]
        [TestCase("MDDDSSSSSF")]
        public void Cattle_CheckControlDigit_ExternalIdentificationNumber(string input)
        {
           // string input = "SK0235232";
            Cattle cattle = new Cattle() {CattleID=input};
            bool result = cattle.CheckControlDigit();
            Assert.IsTrue(result);
        }

    }
}