using AWS2018.Utilities.AWSConfig;

namespace AWS2018.Controller.ViewInterface
{
    public interface IDataLoggerList
    {
        void SetReportViewControl(CommunicationManager controller);
        bool AddDataLogger(AWSEnvionment dataLogerEnvironment);
        bool ModfyDataLogger(AWSEnvionment dataLogerEnvironment);
        bool DeleteDataLogger(string name, ushort awsID);
    }
}
