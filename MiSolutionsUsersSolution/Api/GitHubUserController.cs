using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace MiSolutionsUsersSolution.Api
{
    public class GitHubUserController : ApiController
    {
        public readonly IGitHubDataService<GitHubUser> _gitHubDataService;

        public GitHubUserController(IGitHubDataService<GitHubUser> gitHubDataService)
        {
            _gitHubDataService = gitHubDataService;
        }

        public IList<GitHubUser> Get()
        {
            var result = _gitHubDataService.GetAll();
            return result;
        }

        [HttpPut]
        public void AddOrUpdate([FromUri] GitHubUser user)
        {
            _gitHubDataService.AddOrUpdate(user);
        }
    }
}
