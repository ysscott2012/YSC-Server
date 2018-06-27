using Microsoft.EntityFrameworkCore;
using YSC_Server.DaoModels;

namespace YSC_Server.DbContext
{
    public interface IYscContext: IBaseDbContext
    {
        DbSet<YelpReview> YelpReviews { get; set; }
        DbSet<Algorithm> Algorithms { get; set; }
        DbSet<Leetcode> Leetcodes { get; set; }
    }
}