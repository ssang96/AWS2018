using AWS2018.Utilities;
using System;
using System.Data.Linq;
using System.Data.OleDb;
using System.Linq;

namespace AWS2018.Model.Datas
{
    public class WeatherContext
    {
        public Result<IQueryable<WeatherDailyModel>> getWeahterDaily(string connString)
        {
            OleDbConnection oleDBConn = null;
            DataContext dataContext = null;
            
            try
            {
                oleDBConn = new OleDbConnection(connString);
                dataContext = new DataContext(oleDBConn);

                var result = dataContext.GetTable<WeatherDailyModel>().AsQueryable();
                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail<IQueryable<WeatherDailyModel>>("File isn't exist In " + ex.Message);
            }
            finally
            {
                oleDBConn.Close();
                dataContext.Dispose();
            }
        } 

        public Result addWeatherDailyModel<T>(T weather)
        {
            return Result.Ok("");
        }
       
        public Result addWeatherMonthlyModel<T>(T weather)
        {
            return Result.Ok("");
        }
    }
}
