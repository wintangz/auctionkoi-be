﻿using KoiAuction.Domain.Entities;
using KoiAuction.Domain.Repositories;

namespace KoiAuction.Domain.IRepositories
{
    public interface IBlogRepository : IEFRepository<BlogEntity, BlogEntity>
    {

    }
}
