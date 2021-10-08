﻿using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;

namespace TradingCompany.DAL.Repositories.Abstract
{
    public interface IOrdersToProductsRepository : IBaseRepository<OrderToProduct, OrderToProductFilter>
    {
    }
}