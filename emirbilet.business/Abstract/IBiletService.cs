using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.business.Abstract
{
    public interface IBiletService
    {
        Bilet GetById(int id);
        void Create(Bilet entity);
        void Update(Bilet entity);
        void Delete(Bilet entity);
        void Update(Bilet entity, int[] biletIds);
        List<Bilet> GetAll();
        int GetCountByKoltuk(int guzergahId);
        List<int> GetKoltuk(int guzergahId);
        Bilet GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
    }
}
