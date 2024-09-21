using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class recipes
{
    [JsonProperty("instructions")]
    public string instructions { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("ingredients")]
    public string[] ingredients { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("recipes")]
    public recipes[] recipes { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
