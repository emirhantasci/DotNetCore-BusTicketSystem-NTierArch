using emirbilet.business.Abstract;
using emirbilet.data.Abstract;
using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.business.Concrete
{
    public class GuzergahManager:IGuzergahService
    {
        private IGuzergahRepository _guzergahRepository;
        public GuzergahManager(IGuzergahRepository guzergahRepository)
        {
            _guzergahRepository = guzergahRepository;
        }

        public void Create(Guzergah entity)
        {
            _guzergahRepository.Create(entity);
        }

        public void Delete(Guzergah entity)
        {
            _guzergahRepository.Delete(entity);
        }

        public List<Guzergah> GetAll()
        {
            return _guzergahRepository.GetAll();
        }

        public Guzergah GetById(int id)
        {
            throw new NotImplementedException();
        }

       

        public int GetGuzergahByBslBts(string basl, string gz1, string gz2, string gz3, string bts)
        {
            return _guzergahRepository.GetGuzergahByBslBts(basl, gz1, gz2, gz3, bts);
        }

        public Guzergah GetGuzergahDetails(int id)
        {
            return _guzergahRepository.GetGuzergahDetails(id);
        }

        public string GetNereden(string nereden)
        {
            return _guzergahRepository.GetNereden(nereden);
        }

        public string GetNereye(string nereye)
        {
            return _guzergahRepository.GetNereye(nereye);
        }

        public List<Guzergah> GetYolculuk(string nereden, string nereye)
        {
            return _guzergahRepository.GetYolculuk(nereden, nereye);
        }

        public void Update(Guzergah entity)
        {
            _guzergahRepository.Update(entity);
        }

        

        
    }
}
