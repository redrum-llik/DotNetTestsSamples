using System;  
using Serilog;

  public class FibonacciExample  
   {  
     public static void Main()  
      {  
Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs\\my_log.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();
         Log.Debug("Foo started");

         }    
      }  


