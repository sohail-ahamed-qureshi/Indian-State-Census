using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensus
{
    class StateCensusException : Exception
    {
        public enum Error
        {
            INVALID_FILE_TYPE,
            INVALID_HEADERS,
            INVALID_FILE_PATH,
            INVALID_DELIMITER,
            INVALID_FILE
        }
        public StateCensusException(Error error, string message)
        {
            Console.WriteLine("Error-- "+error+ " : "+message);
        }
    }
}
