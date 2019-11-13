using Blog.DataAccess;
using UnifiedLMS.Infrastructure.Abstractions;

namespace Blog.Infrastructures.Concrete
{
    public class GeneralQuery : IGeneralQuery
    {
        private BlogDbContext _db { get; }
        public GeneralQuery(BlogDbContext db)
        {
            _db = db;
        }
        public string GetAppId(string userId)
        {
            return "";
        }
    }
}
