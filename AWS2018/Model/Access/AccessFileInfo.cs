using AWS2018.Utilities;
using System;
using System.IO;

namespace AWS2018.Model.Access
{
    public class AccessFileInfo
    {      
        public static Result getAccess(DateTime dateTime)
        {
            var mdbFile = Path.Combine(@"C:\AWS\Data\2018\03\", "aws_" + dateTime.ToString("dd") + ".mdb");
            var isExistFile = File.Exists(mdbFile);

            if (!isExistFile)
                return Result.Fail("File isn't exist In " + mdbFile);

            var connString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);

            return Result.Ok(connString);            
        }
    }
}
