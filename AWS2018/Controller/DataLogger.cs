using AWS2018.Utilities.AWSConfig;

namespace AWS2018.Controller
{
    public class DataLogger
    {      
        public AWSEnvionment AWSEnvionment { get; }

        public DataLogger(AWSEnvionment awsEnvionment)
        {
            AWSEnvionment = awsEnvionment;
        }
        
       
       
    }
}
