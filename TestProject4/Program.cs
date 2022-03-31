using System;  
using Serilog;

  public class FibonacciExample  
   {  
     public static void Main()  
      {  
    using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

            log.Information("Hello, world!");

         }    
      }  


