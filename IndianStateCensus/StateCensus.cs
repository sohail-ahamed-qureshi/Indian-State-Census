using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensus
{
    class StateCensus
    {
        public string State { get; set; }
        public long Population { get; set; }
        public int Area { get; set; }
        public int Density { get; set; }
        /// <summary>
        /// loads the data from the csv file into census model class
        /// </summary>
        public int GetData()
        {
            string filepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCensusData.csv";
            string[] data = File.ReadAllLines(filepath);
            var censusList = new List<StateCensus>();
            //iterator to load the data
            for (int i = 1; i < data.Length; i++)
            {
                string[] censusData = data[i].Split(',');

                State = censusData[0];
                Population = Convert.ToInt64(censusData[1]);
                Area = Convert.ToInt32(censusData[2]);
                Density = Convert.ToInt32(censusData[3]);

                Console.WriteLine($"State : {State} Population: {Population} Area: {Area} Density: {Density}");

            }
            return data.Length;
        }
    }
}
