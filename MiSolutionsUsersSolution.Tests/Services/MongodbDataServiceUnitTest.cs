using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using MiSolutionsGitHub.BusinessLayer.Services;
using Moq;
using NUnit.Framework;

namespace MiSolutionsUsersSolution.Tests.Services
{
    [TestFixture]
    public class MongodbDataServiceUnitTest
    {
        private IUserDataService<GitHubUser> _userDataService;
        private Mock<IConfig> _mockConfig;

        [SetUp]
        public void SetUp()
        {
            _mockConfig = new Mock<IConfig>();
            const string connStr = "mongodb+srv://dbOussHm:Qwerty123456%2a@cluster0.xdvdl.mongodb.net/myFirstDatabase?authSource=admin&replicaSet=atlas-jxcabm-shard-0&w=majority&readPreference=primary&appname=MongoDB%20Compass&retryWrites=true&ssl=true";
            const string dbName = "GitHubApp";
            _mockConfig.SetupGet(x => x.DbConnectionString).Returns(connStr);
            _mockConfig.SetupGet(x => x.DatabaseName).Returns(dbName);
            _userDataService = new MongodbDataService(_mockConfig.Object);
        }

        //Test used to test db connection
        [Test]
        public void TestDbConnection()
        {

            _userDataService.AddOrUpdate(new GitHubUser()
            {
                Avatar = "https://avatars.githubusercontent.com/u/4?v=4",
                ID = 107,
                Login = "oussHm",
                ProfileUrl = "someUrl",
                RepositoriesUrl = "someOtherUrl"
            });


            var user = _userDataService.Get(107);

            Assert.AreNotEqual(null, user);
        }
    }
}
