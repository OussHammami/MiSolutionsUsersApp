using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IGitHubRepositoryService<TRepository>
    {
        /// <summary>
        /// Gets a list of user repositories
        /// </summary>
        /// <param name="reposUrl">url of the repositories</param>
        /// <returns>a list of repositories</returns>
        IList<TRepository> GetRepositories(string reposUrl);
    }
}
