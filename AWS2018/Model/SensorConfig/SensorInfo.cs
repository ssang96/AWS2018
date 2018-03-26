using AWS2018.Utilities.SensorConfig;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AWS2018.Model.SensorConfig
{
    public class SensorInfo
    {  
        public List<Sensor> Sensors { get; set; }
    }
}
