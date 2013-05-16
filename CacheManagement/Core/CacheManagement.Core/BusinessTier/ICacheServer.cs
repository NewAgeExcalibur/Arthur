using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    interface ICacheServer 
    {
        IConnection Connection { get; }
        string ServerName { get; }

    }
}
