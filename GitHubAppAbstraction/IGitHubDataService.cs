using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IGitHubDataService<TUser>
    {
        /// <summary>
        /// Get All saved users union with none saved github users
        /// </summary>
        /// <returns>List of GitHubUser</returns>
        IList<TUser> GetAll();

        /// <summary>
        /// Add new GitHub user or Update it if it exists
        /// </summary>
        void AddOrUpdate(TUser user);
    }
}
