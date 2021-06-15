using GitHubAppAbstraction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.Common
{
    public class JsonConverter : IConverter
    {
        public T DeserializeObject<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }
    }
}
