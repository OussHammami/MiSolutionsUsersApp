using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IWebClient
    {
        /// <summary>
        /// Download result as string of url call
        /// </summary>
        /// <param name="url">called url</param>
        /// <returns>GitHubUser</returns>
        string DownloadString(string url);
    }
}
