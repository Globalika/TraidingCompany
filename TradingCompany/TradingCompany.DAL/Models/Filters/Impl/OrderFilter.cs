﻿using System;
using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class OrderFilter : IFilterable
    {
        public ulong? Id { get; set; }

        public ulong? UserId { get; set; }

        public string Destination { get; set; }

        public DateTime? OrderDate { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nUserId: {1} \nDestination: {2} \nOrderDate: {3}\n",
                Id, UserId, Destination, OrderDate);
        }
    }
}
