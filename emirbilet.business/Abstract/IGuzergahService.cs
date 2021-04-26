using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.business.Abstract
{
    public interface IGuzergahService
    {
        Guzergah GetById(int id);
        void Create(Guzergah entity);
        void Update(Guzergah entity);
        void Delete(Guzergah entity);
        
        List<Guzergah> GetAll();
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Guzergah> GetYolculuk(string nereden, string nereye);
        int GetGuzergahByBslBts(string basl, string gz1, string gz2, string gz3, string bts);
        Guzergah GetGuzergahDetails(int id);
        
    }
}
