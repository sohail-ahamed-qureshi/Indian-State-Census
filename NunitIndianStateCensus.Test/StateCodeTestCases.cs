using System;
using IndianStateCensus;
using NUnit.Framework;

namespace NunitIndianStateCensus.Test
{
    class StateCodeTestCases
    {
        string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        string indianStateCodefilepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCode.csv";
        string wrongfile = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\StateCode.csv";
        string wrongfiletype = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCode.txt";
        string wrongDelimiter = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\DelimiterIndiaStateCode.csv";
        string wrongHeaders = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\WrongIndiaStateCode.csv";
        [Test]
        public void GivenCSVfile_ReturnsNumberOfRecord()
        {
            //Arrange
            int expected = 37;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(indianStateCodefilepath, indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenCSVfileIncorrect_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(wrongfile, indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectFiletype_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(wrongfiletype , indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectDelimiter_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(wrongDelimiter, indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectHeaders_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(wrongHeaders, indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }
    }
}
