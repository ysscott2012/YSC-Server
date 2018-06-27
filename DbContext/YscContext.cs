using Microsoft.EntityFrameworkCore;
using YSC_Server.DaoModels;

namespace YSC_Server.DbContext
{   
    public class YscContext: BaseDbContext, IYscContext
    {
        public virtual DbSet<YelpReview> YelpReviews { get; set; }
        public virtual DbSet<Algorithm> Algorithms { get; set; }
        public virtual DbSet<Leetcode> Leetcodes { get; set; }
        
        public YscContext(DbContextOptions<YscContext> options) : base(options)
        {
        }
    }
}