using Microsoft.EntityFrameworkCore;

namespace YSC_Server.DbContext
{
    public abstract class BaseDbContext: Microsoft.EntityFrameworkCore.DbContext, IBaseDbContext
    {
        protected BaseDbContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}