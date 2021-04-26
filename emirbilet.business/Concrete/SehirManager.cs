using emirbilet.business.Abstract;
using emirbilet.data.Abstract;
using emirbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace emirbilet.business.Concrete
{
    public class SehirManager : ISehirService
    {
        private ISehirRepository _sehirRepository;
        public SehirManager(ISehirRepository sehirRepository)
        {
            _sehirRepository = sehirRepository;
        }
        public void Create(Sehir entity)
        {
            _sehirRepository.Create(entity);
        }

        public void Delete(Sehir entity)
        {
            _sehirRepository.Delete(entity);
        }

        public List<Sehir> GetAll()
        {
            return _sehirRepository.GetAll();
        }

        public Sehir GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string sehirad()
        {
            throw new NotImplementedException();
        }

        public void Update(Sehir entity)
        {
            _sehirRepository.Update(entity);
        }

        public void Update(Sehir entity, int[] sehirIds)
        {
            throw new NotImplementedException();
        }
    }
}
