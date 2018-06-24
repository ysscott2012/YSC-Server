﻿using Microsoft.EntityFrameworkCore;
using YSC_Server.DaoModels;

namespace YSC_Server.DbContext
{
    public interface IYscContext
    {
        DbSet<YelpReview> YelpReviews { get; set; }
    }
}