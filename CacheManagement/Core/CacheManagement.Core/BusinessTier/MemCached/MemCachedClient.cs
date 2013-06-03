using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManagement.Core.BusinessTier.MemCached
{
    public class MemCachedFarm: IFarmStatus, IFarm
    {      

        #region IFarm Members

        public List<IServer> ServerCollection
        {
            get { throw new NotImplementedException(); }
        }

        public string FarmName
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IFarmStatus Members

        public List<CacheStatus> GetStatus<T>() where T : IFarm
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
