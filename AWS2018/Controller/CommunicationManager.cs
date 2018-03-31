using AWS2018.Utilities.SensorConfig;
using System.Collections.Generic;

namespace AWS2018.Controller
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
