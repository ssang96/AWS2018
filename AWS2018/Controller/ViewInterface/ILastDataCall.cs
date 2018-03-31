using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS2018.Controller.ViewInterface
{
    public interface ILastDataCall
    {
        void SetCommandControl(DataLogger controller);
        void StartLastDataCall(DateTime start, DateTime last, ushort awsID);
        void StopLastDataCall(ushort awsID);      

        void SetResult(ushort awsid, string result);
    }
}
