using System.Text.Json.Serialization;

namespace FuckSamsung.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Resource
{
    public string resourceCode;

    public string resourceName;

    public string resourceType;

    public int? resourceSize;

    public string downloadUrl;
}

public class FuckSamsung
{
    public int? version;

    public string modelName;

    public List<Resource> resources;
}

