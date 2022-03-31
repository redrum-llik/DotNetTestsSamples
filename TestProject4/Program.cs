using System;  
using Serilog;

  public class FibonacciExample  
   {  
     public static void Main()  
      {  
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Hello, world!");

         }    
      }  


