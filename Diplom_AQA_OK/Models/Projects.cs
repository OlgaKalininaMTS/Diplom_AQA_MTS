using Diplom_AQA_OK.Models;
using System.Text.Json.Serialization;

namespace Diplom_AQA_OK.Models;

public class Projects
{
    [JsonPropertyName("data")] public Project[] ProjectsList { get; set; }
    [JsonPropertyName("meta")] public Meta Meta { get; set; }
}