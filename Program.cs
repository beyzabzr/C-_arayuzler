using System;
namespace arayuzler
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            Console.WriteLine("***********");

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            Console.WriteLine("***********");

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            Console.WriteLine("***********");

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}