﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier.MemCached
{
    class MemeCachedServer : IServer
    {

        #region IServer Members

        public IConnection Connection
        {
            get { throw new NotImplementedException(); }
        }

        public string ServerName
        {
            get { throw new NotImplementedException(); }
        }

        public long Capacity
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
