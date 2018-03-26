using System;
using System.Data.Linq.Mapping;

namespace AWS2018.Model.Datas
{
    [Table(Name = "AWS_MIN")]
    public class WeatherDailyModel
    {
        [Column(Name = "DEV_IDX")]
        public int DEV_IDX { get; set; }
        [Column(Name = "RECEIVETIME", IsPrimaryKey = true)]
        public DateTime RECEIVETIME { get; set; }
    }
}
