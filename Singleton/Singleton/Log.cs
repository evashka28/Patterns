using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Log
    {
        static Lazy<Log> myLog = new Lazy<Log>(() => new Log());
       
        public static Log MyLog
        {
            get
            {
                return myLog.Value;
            }
        }
        public void LogExecution(string mes)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Loger(mes, w);
                w.Close();
            }
        }
        private static void Loger(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
            w.WriteLine("Действие: {0}", logMessage);
            w.WriteLine("-------------------------------");
        }
    }
}
