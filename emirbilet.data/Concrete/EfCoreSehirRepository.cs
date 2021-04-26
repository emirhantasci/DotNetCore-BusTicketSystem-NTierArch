using emirbilet.data.Abstract;
using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.data.Concrete
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, BiletContext>, ISehirRepository
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
