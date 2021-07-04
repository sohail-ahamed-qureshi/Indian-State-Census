using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianStateCensus
{
    public class StateCensusAnalyser
    {

        public int SrNo { get; set; }
        public string StateName { get; set; }
        public int TIN { get; set; }
        public string StateCode { get; set; }

        /// <summary>
        /// loads the data directly from the csv file
        /// </summary>
        public int GetStateCodeData(string filepath, string headers)
        {
            try
            {
                if (!filepath.EndsWith(".csv"))
                    throw new StateCensusException(StateCensusException.Error.INVALID_FILE_TYPE, "File Extension is invalid");
                //reading the file
                string[] data = File.ReadAllLines(filepath);
                //first line in file contains headers
                if (!headers.Equals(data[0]))
                    throw new StateCensusException(StateCensusException.Error.INVALID_HEADERS, "Invalid Headers found");
                var censusList = new List<StateCensus>();
                //iterator to load the data
                for (int i = 1; i < data.Length; i++)
                {
                    if (!data[i].Contains(','))
                        throw new StateCensusException(StateCensusException.Error.INVALID_DELIMITER, "cannot read file");
                    string[] censusData = data[i].Split(',');
                    SrNo =Convert.ToInt32(censusData[0]);
                    StateName = censusData[1];
                    TIN = Convert.ToInt32(censusData[2]);
                    StateCode =(censusData[3]);
                    Console.WriteLine($"Sr.No : {SrNo} StateName: {StateName} TIN: {TIN} StateCode: {StateCode}");
                }
                return data.Length - 1;
            }
            catch (Exception)
            {
                throw new StateCensusException(StateCensusException.Error.INVALID_FILE, "invalid file passed!!"); ;
            }
        }
    }
}
