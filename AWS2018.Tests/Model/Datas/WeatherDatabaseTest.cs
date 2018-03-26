using AWS2018.Model.Datas;
using NUnit.Framework;


namespace AWS2018.Tests.Model.Datas
{
    [TestFixture]
    public class WeatherDatabaseTest
    {
        [Test]
        public void TestWeatherDatabase()
        {
            WeatherDatabase weatherDatabase = new WeatherDatabase(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"C:\AWS\Data\2018\03\aws.mdb");
        }

        [Ignore("Ignore")]
        public void TestWeatherDatabseSelct()
        {
   

        }
    }
}
