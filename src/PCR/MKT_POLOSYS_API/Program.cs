// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.Program
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace MKT_POLOSYS_API
{
  public class Program
  {
    public static void Main(string[] args) => HostingAbstractionsHostExtensions.Run(Program.CreateHostBuilder(args).Build());

    public static IHostBuilder CreateHostBuilder(string[] args) => GenericHostBuilderExtensions.ConfigureWebHostDefaults(Host.CreateDefaultBuilder(args), (Action<IWebHostBuilder>) (webBuilder => WebHostBuilderExtensions.UseStartup<Startup>(webBuilder)));
  }
}
