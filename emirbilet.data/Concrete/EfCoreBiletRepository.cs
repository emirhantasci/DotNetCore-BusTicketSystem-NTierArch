using emirbilet.data.Abstract;
using emirbilet.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emirbilet.data.Concrete
{
    public class EfCoreBiletRepository : EfCoreGenericRepository<Bilet, BiletContext>, IBiletRepository
    {
        public int GetCountByKoltuk(int guzergahId)
        {
            using (var context = new BiletContext())
            {
                return context.Bilets
                    .Where(i => i.GuzergahId == guzergahId)
                    .Select(i => i.KoltukNo)
                    .Count();
            }
        }

        public List<int> GetKoltuk(int guzergahId)
        {
            using (var context = new BiletContext())
            {
                var koltuk = context.Bilets
                    .Where(i => i.GuzergahId == guzergahId)
                    .Select(i => i.KoltukNo)
                    .ToList();

                return koltuk;
            }
        }

        public string GetSaat()
        {
            throw new NotImplementedException();
        }

        public Bilet GetSonKayit()
        {
            using(var context=new BiletContext())
            {
                var sonbilet = context.Bilets
                    .OrderByDescending(i => i.BiletId)
                    .FirstOrDefault();
                return sonbilet;
            }
        }

        public int GetId()
        {
            using (var context = new BiletContext())
            {
                var id = context.Bilets
                    .OrderByDescending(i => i.BiletId)
                    .Select(i => i.GuzergahId)
                    .FirstOrDefault();
                return id;
            }
        }

        public string GetTarih(int id)
        {
            using (var context = new BiletContext())
            {
                var sonbilettarih = context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .Select(i => i.Tarih)
                    .FirstOrDefault();
                    
                return sonbilettarih;
            }
        }

        public string GetSaat(int id)
        {
            using (var context = new BiletContext())
            {
                var sonbiletsaat = context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .Select(i => i.Saat)
                    .FirstOrDefault();

                return sonbiletsaat;
            }
        }
    }
}
