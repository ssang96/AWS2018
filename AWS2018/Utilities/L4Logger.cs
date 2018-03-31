using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace AWS2018.Utilities
{
    public class L4Logger
    {
        private static L4Logger LoggerInstance;

        public ILog log;
        public RollingFileAppender rollingAppender;
        public PatternLayout layout;
        public log4net.Filter.LoggerMatchFilter lmf;

        public static L4Logger GetInstance()
        {
            if (LoggerInstance == null)
            {
                LoggerInstance = new L4Logger();
            }

            return LoggerInstance;
        }


        public L4Logger()
        {
            string FilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\App.log"; //실행폴더 아래에 Log폴더

            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Configured = true;

            RollingFileAppender rollingAppender = new RollingFileAppender
            {
                Name = "logger",
                File = FilePath, // 로그 파일 이름
                AppendToFile = true,
                StaticLogFileName = true,
                CountDirection = 1,
                RollingStyle = RollingFileAppender.RollingMode.Date,
                LockingModel = new FileAppender.MinimalLock(),
                DatePattern = "_yyyyMMdd\".log\"" // 날짜가 변경되면 이전 로그에 붙은 이름
            };

            PatternLayout layout = new PatternLayout("%date [%-5level] %message%newline");//로그 출력 포맷

            rollingAppender.Layout = layout;

            hierarchy.Root.AddAppender(rollingAppender);
            rollingAppender.ActivateOptions(); ;
            hierarchy.Root.Level = log4net.Core.Level.All;

            log = LogManager.GetLogger("logger");
            Logger l = (Logger)log.Logger;
        }

        public void Add(string LogMsg)
        {
            log.Debug(LogMsg);
        }

        public void Close()
        {
            LogManager.Shutdown();
        }
    }
}
