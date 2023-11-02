using System.Text.Json;
using System.Text.Json.Serialization;
using FuckSamsung.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace FuckSamsung.Controllers;

[Route("/resource/device/v1/list")]
public class FuckSamsungController : Controller
{
    [HttpGet]
    public async Task<string> Respond()
    {
        var response = new Models.FuckSamsung
        {
            version = 1,
            modelName = "FuckSamsung",
            resources = new List<Resource>
            {
                new()
                {
                    downloadUrl =
                        "https://cdn.discordapp.com/avatars/967038397715709962/2f771779b3804ffe30d1d44cb7590c9a.webp?size=2048",
                    resourceCode = "101",
                    resourceName = "connect-main",
                    resourceType = "image/webp",
                    resourceSize = 92916
                }
            }
        };
        return JsonConvert.SerializeObject(response);
    }
}