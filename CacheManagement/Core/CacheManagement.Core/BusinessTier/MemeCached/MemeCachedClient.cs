using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier.MemeCached
{
    public class MemeCachedClient: ICacheClient
    {
        #region ICacheClient Members

        public List<CacheStatus> GetStatus(ICacheServer server)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
