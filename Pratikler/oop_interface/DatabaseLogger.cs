using System;

namespace oop_interface
{
  public class DatabaseLogger : ILogger
  {
    public void WriteLog()
    {
      //throw new NotImplementedException();
      Console.WriteLine("Database Log yazıldı.");
    }
  }
}