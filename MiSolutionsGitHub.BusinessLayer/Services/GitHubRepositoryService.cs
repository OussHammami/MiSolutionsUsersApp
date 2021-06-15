using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.BusinessLayer.Services
{
    public class GitHubRepositoryService : IGitHubRepositoryService<GitHubRepository>
    {
        private readonly IConfig _config;
        private readonly IWebClient _webClient;
        private readonly IConverter _converter;

        public GitHubRepositoryService(IConfig config, IWebClient webClient, IConverter converter)
        {
            _config = config;
            _webClient = webClient;
            _converter = converter;
        }
        public IList<GitHubRepository> GetRepositories(string reposUrl)
        {
            var jsonResult = _webClient.DownloadString(reposUrl);
            return _converter.DeserializeObject<List<GitHubRepository>>(jsonResult);
        }
    }
}
