using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    public abstract class CacheStatus
    {
        public int Port { get; private set; }

        public string Capacity { get; private set; }

        public string MissHits { get; private set; }

        public bool IsStopped { get; private set; }
    }
}
