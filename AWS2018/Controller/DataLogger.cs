using AWS2018.Utilities.AWSConfig;

namespace CommManager.DataLogger
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
