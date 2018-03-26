using AWS2018.Utilities.AWSConfig;
using CommManager.Utilities.AWSConfig;
using CommManager.Utilities.SensorConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommManager.DataLogger
{
    public class CommunicationManager
    {
        private IEnumerable<DataLogger> LoggerList { get; }
        private DataLogger AWS = null;

        public CommunicationManager()
        {
           // AWSConfig config = new AWSConfig();
          //  AWSEnv result = config.Env;

            SesnsorsConfig sesnsorsConfig = new SesnsorsConfig();

            LoggerList = new List<DataLogger>();

        }

        public void Dispose()
        {

        }

    }
}
