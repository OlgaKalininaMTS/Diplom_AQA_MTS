using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Diplom_AQA_OK.Models
{
    public class Meta
    {
        [JsonPropertyName("count")] public int Count { get; set; }
        [JsonPropertyName("limit")] public int Limit { get; set; }
        [JsonPropertyName("offset")] public int Offset { get; set; }
        [JsonPropertyName("totalCount")] public int totalCount { get; set; }
    }
