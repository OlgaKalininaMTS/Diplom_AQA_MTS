using System.Text.Json.Serialization;

namespace Diplom_AQA_OK.Models;

public class Permission
{
    [JsonPropertyName("permission")] public required string Permissions { get; set; }
}