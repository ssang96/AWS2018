using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommManager.Datas.AccessDB
{
    interface IDatabaseAccess
    {
        System.Data.Common.DbConnection Connect(string connStr);
        void Close();
        double[] GetSensorMaxData();
        double[] GetSensorMinData();
        void InsertSensorData<T>(DateTime dt, int dev_idx, T kma, double[] min_values, double[] max_values);
        double[] GetSensorAvgData();        
    }
}
