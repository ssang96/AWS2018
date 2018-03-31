using AWS2018.Model.Datas;
using AWS2018.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

namespace AWS2018.Test
{
    [TestClass]
    public class WeatherDatabaseTest
    {
        [TestMethod]
        public void TestWeatherDatabaseConnection()
        {
            string mdbFile = Path.Combine(@"C:\AWS\Data\2018\03\", "aws.mdb");
            string connString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);


            //Result<IQueryable<WeatherDailyModel>> result = WeatherContext.getWeahterDaily(System.DateTime.Now);

            //if (result.IsSuccess)
            //{
            //    IQueryable<WeatherDailyModel> results = result.Value;

            //    Console.WriteLine(results.Select(data => data.AwsID).ToString());   
            //}      

            //Console.WriteLine("he");
        }


        
    }
}
