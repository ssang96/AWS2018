using System;

namespace AWS2018.Controller.ViewInterface
{
    public interface ICommand
    {
        void SetCommandControl(CommunicationManager controller);
        bool Reset(ushort awsID);
        bool BufferClear(ushort awsID);
        bool GetRealDatas(DateTime startDate, ushort awsID);
        bool TimeSync(ushort awsID);
        bool SetPassword(ushort awsID, ushort newPassword);
        bool SetAWSID(ushort original, ushort newAWSID);

        bool SetResult(ushort awsid, string result);
    }
}
