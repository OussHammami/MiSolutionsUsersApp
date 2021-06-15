using GitHubAppAbstraction;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.BusinessLayer.Configurations
{
    public class Config: IConfig
    {
        public string GitHubUrl => string.IsNullOrEmpty(ConfigurationManager.AppSettings["gitHub.URL"])
           ? string.Empty
           : ConfigurationManager.AppSettings["gitHub.URL"];

        public string DbConnectionString => string.IsNullOrEmpty(ConfigurationManager.AppSettings["connectionString"])
           ? string.Empty
           : ConfigurationManager.AppSettings["connectionString"];

        public string DatabaseName => string.IsNullOrEmpty(ConfigurationManager.AppSettings["database"])
           ? string.Empty
           : ConfigurationManager.AppSettings["database"];
    }
}
