using MiSolutionsUsersSolution.Models;
using System.Web.Mvc;

namespace MiSolutionsUsersSolution.Controllers
{
    public class RepositoryController : Controller
    {
        public ActionResult Index(string url, string login)
        {
            GitHubUserModel userModel = new GitHubUserModel() { RepositoriesUrl = url, Login = login };
            return View("Index", model: userModel);
        }

    }
}
