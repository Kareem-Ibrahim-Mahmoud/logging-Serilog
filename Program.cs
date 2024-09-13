using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_one_c_sharp
{


    internal class emp
    {


        static void Main(string[] args)
        {
            /*
            Log.Logger = new LoggerConfiguration()
          .WriteTo.Console()  
          .CreateLogger();
            */


            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
           .WriteTo.File(@"D:\c sharp prog\Serilog and nlog\Serilog.txt", rollingInterval: RollingInterval.Infinite) 
           .CreateLogger();

            // بدء حلقة for لتسجيل 100,000 عملية
            for (int i = 1; i <= 100000; i++)
            {
                Log.Information("Iteration {i} of the loop", i);  // تسجيل قيمة i
            }

            // إنهاء Serilog بشكل صحيح للتأكد من كتابة جميع الـ logs
            Log.CloseAndFlush();

            Console.WriteLine("Logging completed. Check the logs file.");







        }



    }
}       
