using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer;
using MiSolutionsGitHub.BusinessLayer.Configurations;
using MiSolutionsGitHub.BusinessLayer.Models;
using MiSolutionsGitHub.BusinessLayer.Services;
using MiSolutionsGitHub.Common;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;

namespace MiSolutionsUsersSolution.App_Start
{
    public static class IocConfig
    {
        public static void RegisterDependencies()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Register<IConfig, Config>();
            container.Register<IConverter, JsonConverter>();
            container.Register<IWebClient, CustomWebClient>();
            container.Register<IGitHubUserService<GitHubUser>, GitHubUserService>();
            container.Register<IGitHubRepositoryService<GitHubRepository>, GitHubRepositoryService>();
            container.Register<IGitHubDataService<GitHubUser>, GitHubMongodbService>();
            container.Register<IUserDataService<GitHubUser>, MongodbDataService>();
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver =  new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}