using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS2018.Controller.ViewInterface
{
    public interface IGraphView
    {
       // void SetGraphViewControl(GraphController controller);
        DataTable ReadTimeData(DateTime dateTime, string name, ushort awsid);
    }
}
