using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SneakerShowcaseServer.Api.Entities;

namespace SneakerShowcaseServer.Api.UtilsDir;

public static class Utils
{
    public static List<Sneaker> ReadJSON()
    {
        var filePath = Path.Combine(AppContext.BaseDirectory, "Data/SneakerData.json");
        var json = File.ReadAllText(filePath);

        var data = JsonSerializer.Deserialize<List<Sneaker>>(json);

        return data!;
        
    }


}
