using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Comparer;
using MiSolutionsGitHub.BusinessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiSolutionsGitHub.BusinessLayer.Services
{
    public class GitHubMongodbService : IGitHubDataService<GitHubUser>
    {

        public readonly IUserDataService<GitHubUser> _userDataService;

        public readonly IGitHubUserService<GitHubUser> _userGitHubService;

        public GitHubMongodbService(IUserDataService<GitHubUser> userDataService, IGitHubUserService<GitHubUser> userGitHubService)
        {
            _userDataService = userDataService;
            _userGitHubService = userGitHubService;
        }

        public IList<GitHubUser> GetAll()
        {
            IList<GitHubUser> allGitHubUsers = _userDataService.GetAll();
            IList<GitHubUser> allDbUsers = _userGitHubService.GetAll();

            return allGitHubUsers.Union(allDbUsers, new UserUniqueComparer()).ToList();
        }
        public void AddOrUpdate(GitHubUser user)
        {
            _userDataService.AddOrUpdate(user);
        }
    }
}
