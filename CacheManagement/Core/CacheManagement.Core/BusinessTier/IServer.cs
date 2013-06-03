using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier
{
    public interface IServer 
    {
        IConnection Connection { get; }

        string ServerName { get; }

        long Capacity { get; }
    }
}
