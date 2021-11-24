// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.Startup
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace MKT_POLOSYS_API
{
  public class Startup
  {
    public Startup(IConfiguration configuration) => this.Configuration = configuration;

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services) => MvcServiceCollectionExtensions.AddControllers(services);

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (HostEnvironmentEnvExtensions.IsDevelopment((IHostEnvironment) env))
        DeveloperExceptionPageExtensions.UseDeveloperExceptionPage(app);
      HttpsPolicyBuilderExtensions.UseHttpsRedirection(app);
      EndpointRoutingApplicationBuilderExtensions.UseRouting(app);
      AuthorizationAppBuilderExtensions.UseAuthorization(app);
      EndpointRoutingApplicationBuilderExtensions.UseEndpoints(app, (Action<IEndpointRouteBuilder>) (endpoints => ControllerEndpointRouteBuilderExtensions.MapControllers(endpoints)));
    }
  }
}
