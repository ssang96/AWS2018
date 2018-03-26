using AWS2018.Utilities;
using AWS2018.Utilities.AWSConfig;
using System;
using System.IO;

namespace CommManager.Utilities.AWSConfig
{
    class AWSConfig
    {
        public string AWSConfiguration { get; private set; } = @"C:\AWS\AWSCONFIG\AWSENV.xml";
        public AWSEnvionment Env { get; private set; }

        private L4Logger Log = L4Logger.GetInstance();

        public AWSConfig()
        {
            this.ReadConfig();
        }

        public AWSConfig(string filePath)
        {
            AWSConfiguration = filePath;
        }

        private void ReadConfig()
        {
            string xmlInputData = string.Empty;

            try
            {
                xmlInputData = File.ReadAllText(AWSConfiguration);
                Env = Serializer.Deserialize<AWSEnvionment>(xmlInputData);
            }
            catch (ArgumentException ex)
            {
                Log.Add($"AWSConfig ArgumentException Error {ex}");
            }
            catch(DirectoryNotFoundException ex)
            {
                Log.Add($"AWSConfig DirectoryNotFoundException Error {ex}");
                throw;
            }
        }
    }
}
