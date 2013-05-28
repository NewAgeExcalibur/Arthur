using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier.MemCached
{
    public class MemeCachedStatus : CacheStatus
    {
        //could we move it to to another object ???
        public string Version { get; private set; }

        public int Uptime { get; private set; }

        public long CurrentItems { get; private set; }
        public long TotalItems { get; private set; }
        public long UsedBytes { get; private set; }
        public long CurrentConnections { get; private set; }
        public long TotalConnections { get; private set; }
        public long CommandGet { get; private set; }
        public long CommandSet { get; private set; }
        public long GetHits { get; private set; }
        public long GetMisses { get; private set; }
        public long BytesRead { get; private set; }
        public long BytesWritten { get; private set; }
        public long LimitMaxBytes { get; private set; }
    }
}
