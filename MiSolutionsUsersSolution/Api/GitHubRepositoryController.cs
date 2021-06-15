using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiSolutionsUsersSolution.Api
{
    public class GitHubRepositoryController : ApiController
    {
        public readonly IGitHubRepositoryService<GitHubRepository> _gitHubRepoService;

        public GitHubRepositoryController(IGitHubRepositoryService<GitHubRepository> gitHubRepoService)
        {
            _gitHubRepoService = gitHubRepoService;
        }

        public IList<GitHubRepository> Get(string reposUrl)
        {
            var result = _gitHubRepoService.GetRepositories(reposUrl);
            return result;
        }
    }
}
