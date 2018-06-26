using Microsoft.EntityFrameworkCore;
using YSC_Server.DaoModels;

namespace YSC_Server.DbContext
{   
    public class YscContext: BaseDbContext, IYscContext
    {
        public YscContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<YelpReview> YelpReviews { get; set; }
        public DbSet<Algorithm> Algorithms { get; set; }
        public DbSet<Leetcode> Leetcodes { get; set; }
    }
}