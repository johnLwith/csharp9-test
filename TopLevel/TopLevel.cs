//using System.Runtime.InteropServices;
//using Microsoft.AspNetCore;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Server.Kestrel.Core;
//using Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;

//WebHost.Start(async (context) => { await context.Response.WriteAsync("hello"); })
//    .Run();

//await WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().RunAsync();

//public class Startup
//{
//    public void Configure(IApplicationBuilder app) 
//    {
//        app.Run(async (context) => { await context.Response.WriteAsync("hello"); });
//    }
//}

//using System;
//using System.Threading.Tasks;

////int returnValue = int.Parse(Console.ReadLine());
////return returnValue;

////Console.Write("Hello ");
////await Task.Delay(5000);
////Console.WriteLine("World!");


////if (args.Length > 0)
////{
////    foreach (var arg in args)
////    {
////        Console.WriteLine($"Argument={arg}");
////    }
////}
////else
////{
////    Console.WriteLine("No arguments");
////}

//Console.WriteLine("Hello World in TopLevel!");
//return 1;


//public class MyClass
//{
//    public static void TestMethod()
//    {
//        Console.WriteLine("Hello World!");
//    }

//}

