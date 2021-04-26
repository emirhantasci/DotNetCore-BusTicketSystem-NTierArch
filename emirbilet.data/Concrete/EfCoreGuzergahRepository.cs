using emirbilet.data.Abstract;
using emirbilet.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emirbilet.data.Concrete
{
    public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah, BiletContext>, IGuzergahRepository
    {
        public int GetGuzergahByBslBts(string basl, string gz1, string gz2, string gz3, string bts)
        {
            throw new NotImplementedException();
        }

        public Guzergah GetGuzergahDetails(int id)
        {
            using(var context = new BiletContext())
            {
                return context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public string GetNereden(string nereden)
        {
            using (var context = new BiletContext())
            {
                var nrdn = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAd)
                    .ToList();
                return nrdn[0];
            }
        }

        public string GetNereye(string nereye)
        {
            using(var context = new BiletContext())
            {
                var nry = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAd)
                    .ToList();
                return nry[0];
            }
        }

        public List<Guzergah> GetYolculuk(string nereden, string nereye)
        {
            using (var context = new BiletContext())
            {
                var nrdn = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAd)
                    .ToList();
                var nry = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAd)
                    .ToList();
                var guzergahs = context.Guzergahs
                    .FromSqlRaw($"select * from Guzergahs where ((Baslangic='{nrdn[0]}' or gz1='{nrdn[0]}' or gz2='{nrdn[0]}' or gz3='{nrdn[0]}' ) and (Bitis='{nry[0]}' or gz3='{nry[0]}' or gz2='{nry[0]}' or gz1='{nry[0]}' )) ")
                    .ToList();

                return guzergahs;

            }
        }

        
    }
}
