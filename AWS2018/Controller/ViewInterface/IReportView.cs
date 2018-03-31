using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWS2018.Controller.ViewInterface
{
    public interface IReportView
    {
        void SetReportViewControl(ReportViewController controller);
        bool ReadTimeData(DateTime dateTime, string name, ushort awsid);
        bool ReadDayData(DateTime dateTime, string name);
        bool ReadMonthData(DateTime dateTime, string name);
    }
}
