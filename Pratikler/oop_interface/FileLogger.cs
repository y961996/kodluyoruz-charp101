using System;

namespace oop_interface
{
  public class FileLogger : ILogger
  {
    public void WriteLog()
    {
      //throw new NotImplementedException();
      Console.WriteLine("File Log yazıldı.");
    }
  }
}