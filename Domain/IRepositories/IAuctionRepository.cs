﻿using KoiAuction.Domain.Entities;
using KoiAuction.Domain.Repositories;

namespace KoiAuction.Domain.IRepositories
{
    public interface IAuctionRepository : IEFRepository<AuctionEntity, AuctionEntity>
    {

    }
}
