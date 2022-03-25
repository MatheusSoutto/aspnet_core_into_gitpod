using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DotNetIntro.Docker.Models;

public class Product
{
    public string Id { get; set; }

    public string Name { get; set; }

    [JsonPropertyName("img")]
    public string Image { get; set; }

    public string Url { get; set; }

    public string Role { get; set; }

    public override string ToString() => JsonSerializer.Serialize<Product>(this);
}
