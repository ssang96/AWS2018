using AWS2018.Model.Datas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace AWS2018.Test
{
    [TestClass]
    public class WeatherDatabaseTest
    {
        [TestMethod]
        public void TestWeatherDatabaseConnection()
        {
            //string mdbFile = Path.Combine(@"C:\AWS\Data\2018\03\", "aws.mdb");
            //string connString = string.Format(
            //    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);


            //WeatherDatabase weatherDatabase = new WeatherDatabase(mdbFile);

            //try
            //{

            //    var result = weatherDatabase.ExecuteQuery<WeatherDataTable>(@"select * from AWS_MIN");

            //    Console.WriteLine(result.GetEnumerator().Current);
            //} 
            //catch(Exception ex)
            //{
            //    System.Console.WriteLine(ex.GetBaseException());
            //}

            //    weather.
            //   IEnumerator e = weather.GetEnumerator();

            string mdbFile = Path.Combine(@"C:\AWS\Data\2018\03\", "aws.mdb");
            string connString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);

         //   OleDbConnection con = new OleDbConnection(connString);

         //   DataContext db = new DataContext(con);

         //   WeatherContext db = new WeatherContext(connString);

          //  var PersonTable = db.GetTable<WeatherDailyModel>();

         


            //foreach (WeatherData p in PersonTable)
            //{
            //    Console.WriteLine($"{p.DEV_IDX}, {p.RECEIVETIME}");
            //}




                OleDbConnection conn = new OleDbConnection(connString);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM aws_min;", conn);

            DataSet myDataSet = new DataSet();
            adapter.Fill(myDataSet, "AWS_MIN");


        }
    }
}
