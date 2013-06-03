﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    public interface IFarmStatus
    {
        List<CacheStatus> GetStatus<T>() where T : IFarm;

    }
}