using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    //needs to be more generalized , currently its got a hug dependency to memcache
    interface IStatus
    {
        int Uptime { get;   }
        string Version { get;   }
        long CurrentItems { get;  }
        long TotalItems { get;  }
        long UsedBytes { get; }
        long CurrentConnections { get; }
        long TotalConnections { get;   }
        long CommandGet { get; }
        long CommandSet { get; }
        long GetHits { get; }
        long GetMisses { get; }
        long BytesRead { get; }
        long BytesWritten { get;}
        long LimitMaxBytes { get;}

        /// <summary>
        /// Calculated property
        /// </summary>
        bool IsStopped { get;}

    }
}
