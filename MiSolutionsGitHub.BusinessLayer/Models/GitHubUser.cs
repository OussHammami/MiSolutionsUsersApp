using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiSolutionsGitHub.BusinessLayer.Models
{
    [BsonIgnoreExtraElements]
    public class GitHubUser
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("avatar_url")]
        public string Avatar { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("url")]
        public string ProfileUrl { get; set; }
        [JsonProperty("repos_url")]
        public string RepositoriesUrl { get; set; }

    }
}