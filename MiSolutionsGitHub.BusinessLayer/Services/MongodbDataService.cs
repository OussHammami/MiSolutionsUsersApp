using GitHubAppAbstraction;
using MiSolutionsGitHub.BusinessLayer.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSolutionsGitHub.BusinessLayer.Services
{
    public class MongodbDataService: IUserDataService<GitHubUser>
    {
        private readonly IMongoDatabase _db;
        public MongodbDataService(IConfig config)
        {
            var client = new MongoClient(config.DbConnectionString);
            _db = client.GetDatabase(config.DatabaseName);
        }
        public IList<GitHubUser> GetAll()
        {
            var dbUsers = _db.GetCollection<GitHubUser>("GitHubUsers");
            return dbUsers.AsQueryable().ToList();
        }

        public void AddOrUpdate(GitHubUser user)
        {
            var dbUsers = _db.GetCollection<GitHubUser>("GitHubUsers");
            if(Get(user.ID) == null)
            {
                dbUsers.InsertOne(user);
            }
            else
            {
                dbUsers.FindOneAndUpdate(Builders<GitHubUser>.Filter.Eq("ID", user.ID),
                                     Builders<GitHubUser>.Update.Set("Login", user.Login));
            }
        }

        public GitHubUser Get(int id)
        {
            var dbUsers = _db.GetCollection<GitHubUser>("GitHubUsers");
            return dbUsers.Find(Builders<GitHubUser>.Filter.Eq(x => x.ID, id)).FirstOrDefault();
        }
    }
}
