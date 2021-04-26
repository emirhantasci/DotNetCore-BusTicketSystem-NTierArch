using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.data.Abstract
{
    public interface ISehirRepository:IRepository<Sehir>
    {
        string sehirad();
    }
}
