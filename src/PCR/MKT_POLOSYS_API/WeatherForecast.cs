// Decompiled with JetBrains decompiler
// Type: MKT_POLOSYS_API.WeatherForecast
// Assembly: MKT_POLOSYS_API, Version=3.0.2021.1122, Culture=neutral, PublicKeyToken=null
// MVID: 0E9087E7-2B39-44D3-B7CE-E5CF7C87BA61
// Assembly location: D:\Z\SonarQube\Sample Test\sonarqube-scanner Test2\Object Deployment\POLO\PCR\API\MKT_POLOSYS_API.dll

using System;

namespace MKT_POLOSYS_API
{
  public class WeatherForecast
  {
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int) ((double) this.TemperatureC / 0.5556);

    public string Summary { get; set; }
  }
}
