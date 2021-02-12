﻿using Business.Abstract;
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

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(c => c.BrandId == id);
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
