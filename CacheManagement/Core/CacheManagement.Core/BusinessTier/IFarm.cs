using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    interface IFarm 
    {
        List<ICacheServer> ServerCollection { get; }

        string FarmName { get; }
    }
}
