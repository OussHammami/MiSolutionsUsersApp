using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiSolutionsGitHub.BusinessLayer.Models
{
    public class GitHubRepository
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("html_url")]
        public string RepositoryPage { get; set; }
    }
}