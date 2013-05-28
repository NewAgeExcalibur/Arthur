using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    public interface ICacheClient
    {
        List<CacheStatus> GetStatus(ICacheServer server);
    }
}
