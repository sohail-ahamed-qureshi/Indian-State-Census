using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianStateCensus
{
    class StateCensusAnalyser
    {
        /// <summary>
        /// loads the data directly from the csv file
        /// </summary>
        public int GetData()
        {
            string filepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Indian-State-Census\IndianStateCensus\Indian state census data\IndiaStateCensusData.csv";
            string[] data = File.ReadAllLines(filepath);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            return data.Length;
        }
    }
}
