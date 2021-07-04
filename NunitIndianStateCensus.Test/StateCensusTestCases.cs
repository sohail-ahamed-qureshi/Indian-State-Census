using NUnit.Framework;
using IndianStateCensus;

namespace NunitIndianStateCensus.Test
{
    public class Tests
    {
        string indianStateHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        string indianStateCensusfilepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCensusData.csv";
        string wrongfiletype = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCensusData.txt";
        string wrongfile = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaState.csv";

        [Test]
        public void GivenCSVfile_ReturnsNumberOfRecord()
        {
            //Arrange
            int expected = 29;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(indianStateCensusfilepath, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenCSVfileIncorrect_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(wrongfile, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectFiletype_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(wrongfiletype, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }
    }
}