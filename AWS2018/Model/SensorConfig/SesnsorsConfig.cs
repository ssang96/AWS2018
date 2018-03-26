using AWS2018.Model.SensorConfig;
using AWS2018.Utilities;
using System;
using System.IO;
using System.Linq;

namespace CommManager.Utilities.SensorConfig
{
    public class SesnsorsConfig
    {
        public string SensorsConfigFile { get; set; } = @"C:\AWS\SENSORCONFIG\Sensors.xml";
     
        private L4Logger Log = L4Logger.GetInstance();

        public SesnsorsConfig() 
        {
            this.ReadConfig();
        }

        public SesnsorsConfig(string filePath)
        {
            SensorsConfigFile = filePath;
            this.ReadConfig();
        }
       
        private Result ReadConfig()
        {
            string xmlInputData = string.Empty;
     
            try
            {
                xmlInputData = File.ReadAllText(SensorsConfigFile);
                SensorInfo sensors = Serializer.Deserialize<SensorInfo>(xmlInputData);
                System.Console.WriteLine(sensors.Sensors.Count());
                return Result.Ok();
            }
            catch (ArgumentException ex)
            {   
                Log.Add($"AWSConfig ArgumentException Error {ex}");
                return Result.Fail($"AWSConfig ArgumentException Error {ex}");
            }
            catch (DirectoryNotFoundException ex)
            {               
                return Result.Fail($"AWSConfig ArgumentException Error {ex}");
            }
        }
    }
}
