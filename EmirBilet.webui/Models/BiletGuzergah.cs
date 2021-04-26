using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmirBilet.webui.Models
{
    public class BiletGuzergah
    {
        public List<emirbilet.entity.Bilet> Bilets { get; set; }
        public List<Guzergah> Guzergahs { get; set; }
        public List<Sehir> Sehirs { get; set; }
        public Guzergah YeniGuzergah { get; set; }
        public string saat { get; set; }
        public string tarih { get; set; }
        public Bilet bilet { get; set; }

    }
}
