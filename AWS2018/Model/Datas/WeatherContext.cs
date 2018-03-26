using AWS2018.Utilities;
using CommManager.Datas.KMAProtocols;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.OleDb;
using System.IO;

namespace AWS2018.Model.Datas
{
    public class WeatherContext
    {
        public string DailyDataFilePath { get; }
        public string MonthlyDataFilePaht { get; }

        public WeatherContext()
        {

        }

        public static IEnumerable<WeatherDailyModel> getWeahterDaily(DateTime date)
        {
            string mdbFile = Path.Combine(@"C:\AWS\Data\2018\03\", "aws.mdb");
            string connString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);

            OleDbConnection con = new OleDbConnection(connString);
            DataContext db = new DataContext(con);
            var weatherData = db.GetTable<WeatherDailyModel>();
            return weatherData;
        }

        public static Result setWeatherMonthlyModel(KMA2Weather kMA2)
        {
            return Result.Ok();
        }
    }
}
