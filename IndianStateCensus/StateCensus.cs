using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensus
{
    public class StateCensus
    {
        public string State { get; set; }
        public long Population { get; set; }
        public int Area { get; set; }
        public int Density { get; set; }
        /// <summary>
        /// loads the data from the csv file into census model class
        /// </summary>
        public int GetData(string filepath, string headers)
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
                    State = censusData[0];
                    Population = Convert.ToInt64(censusData[1]);
                    Area = Convert.ToInt32(censusData[2]);
                    Density = Convert.ToInt32(censusData[3]);
                    Console.WriteLine($"State : {State} Population: {Population} Area: {Area} Density: {Density}");
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
