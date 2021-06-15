using MiSolutionsGitHub.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.BusinessLayer.Comparer
{
    class UserUniqueComparer : IEqualityComparer<GitHubUser>
    {
        public bool Equals(GitHubUser x, GitHubUser y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(GitHubUser obj)
        {
            return obj.ID.GetHashCode();
        }
    }
}
