namespace AWS2018.Utilities.AWSConfig
{
    public class AWSEnvionment
    {
        public string Communication { get; set; }
        public string Name { get; set; }
        public string LocNumber { get; set; }
        public ushort AWSID { get; set; }
        public ushort Password { get; set; }
        public bool Enable { get; set; }

        //SERIAL
        public string Comport { get; set; }
        public string Parity { get; set; }
        public int Stop { get; set; }
        public int Databit { get; set; }
        public int Baudrate { get; set; }

        //TCP
        public string IP { get; set; }
        public int Port { get; set; }

        //PROTOCOL
        public string Protocol { get; set; }
    }
}
