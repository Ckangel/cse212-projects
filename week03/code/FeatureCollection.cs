using System.Text.Json;

public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public double? Mag { get; set; }
}

public class EarthquakeService
{
    //  sTEP 2: Implement the EarthquakeailySummary Function
    //  Update of function to extract and format the data:
    public static string[] EarthquakeDailySummary()
    {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        if (featureCollection?.Features == null)
            return Array.Empty<string>();

        var summaries = new List<string>();

        foreach (var feature in featureCollection.Features)
        {
            var place = feature.Properties?.Place;
            var mag = feature.Properties?.Mag;

            if (!string.IsNullOrWhiteSpace(place) && mag.HasValue)
            {
                summaries.Add($"{place} - Mag {mag.Value:F2}");
            }
        }

        return summaries.ToArray();
    }
}
