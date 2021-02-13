using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi");
            }

            else
            {
                Console.WriteLine("Marka ismi en az 2 karakterli olmalıdır.");
            }
          
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int BrandId)
        {
            return _brandDal.Get(c => c.BrandId == BrandId);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka güncellendi.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz marka ismi en az 2 karakterli olmalıdır.");
            }
            
        }
    }
}
