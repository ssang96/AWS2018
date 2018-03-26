
namespace AWS2018.Utilities.SensorConfig
{
   
    public class Sensor
    {
        public string Name { get; set; }
        public float Maximum { get; set; }
        public float Minimum { get; set; }
        public string Unit { get; set; }
        public int Position { get; set; }
        public bool IsUseMaximum { get; set; }
        public bool IsUseMinimum { get; set; }           
    }
}
