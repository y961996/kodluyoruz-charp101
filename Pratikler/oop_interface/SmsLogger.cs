using System;

namespace oop_interface
{
  public class SmsLogger : ILogger
  {
    public void WriteLog()
    {
      //throw new NotImplementedException();
      Console.WriteLine("Sms Log yazıldı.");
    }
  }
}