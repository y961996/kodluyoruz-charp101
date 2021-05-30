using System;

namespace oop_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            // ------------------------------
            LogManager logManager = new(new FileLogger());
            logManager.WriteLog();
        }
    }
}
