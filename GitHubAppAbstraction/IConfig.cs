using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IConfig
    {
        /// <summary>
        /// Configuration of GitHub URL
        /// </summary>
        string GitHubUrl { get; }

        /// <summary>
        /// Database connection string
        /// </summary>
        string DbConnectionString { get; }

        /// <summary>
        /// Database Name
        /// </summary>
        string DatabaseName { get; }
    }
}
