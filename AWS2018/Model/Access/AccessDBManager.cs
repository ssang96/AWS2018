using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommManager.Datas.AccessDB
{
    public class AccessDBManager
    {
        public string ConnString { get; }

        public AccessDBManager(string mdbFileName)
        {
            this.ConnString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFileName);
        }
    }
}
