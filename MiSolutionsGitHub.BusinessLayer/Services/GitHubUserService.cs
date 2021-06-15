using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.BusinessLayer.Services
{
    public class GitHubUserService : IGitHubUserService<GitHubUser>
    {
        private readonly IConfig _config;
        private readonly IWebClient _webClient;
        private readonly IConverter _converter;

        public GitHubUserService(IConfig config, IWebClient webClient, IConverter converter)
        {
            _config = config;
            _webClient = webClient;
            _converter = converter;
        }

        public IList<GitHubUser> GetAll()
        {
            var jsonResult = _webClient.DownloadString(_config.GitHubUrl);
            var gitHubUsers = _converter.DeserializeObject<List<GitHubUser>>(jsonResult);

            return gitHubUsers;
        }

        public GitHubUser Get(int id)
        {
            return GetAll().Where(x => x.ID == id).Single();
        }
    }
}
