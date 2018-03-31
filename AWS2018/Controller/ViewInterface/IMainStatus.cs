namespace AWS2018.Controller.ViewInterface
{
    public interface IMainStatus
    {
        void SetReportViewControl(DataLogger controller);
        void SetStatus(string status, string name, ushort awsid);
    }
}
