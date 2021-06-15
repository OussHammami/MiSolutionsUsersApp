using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IGitHubUserService<TUser>
    {
        /// <summary>
        /// Get GitHub Users 
        /// </summary>
        /// <returns>GitHubUsers</returns>
        IList<TUser> GetAll();


        /// <summary>
        /// Get GitHub User
        /// </summary>
        TUser Get(int id);

    }
}
