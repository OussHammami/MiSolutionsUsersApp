using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IUserDataService<TUser>
    {
        /// <summary>
        /// Get All Saved users
        /// </summary>
        /// <returns>List of GitHubUser</returns>
        IList<TUser> GetAll();


        /// <summary>
        /// Add new GitHub user or Update it if it exists
        /// </summary>
        void AddOrUpdate(TUser user);

        /// <summary>
        /// Get User by ID
        /// </summary>
        TUser Get(int id);
    }
}
