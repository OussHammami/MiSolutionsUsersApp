using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAppAbstraction
{
    public interface IConverter
    {
        /// <summary>
        /// Get deserialized object
        /// </summary>
        /// <param name="input">serialized input</param>
        /// <returns>GitHubUser</returns>
        T DeserializeObject<T>(string input);
    }
}
