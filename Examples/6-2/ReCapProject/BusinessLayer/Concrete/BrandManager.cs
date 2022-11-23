using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByID(int Id)
        {
            return _brandDal.Get(b => b.Id == Id);
        }
        public void Add(Brand brand)
        {
            if (brand.Id==brand.Id)
            {
                Console.WriteLine("Ekleme Islemi Basarisiz. Bu Marka Daha Once Eklenmis !!!");
            }
            else
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka Eklendi");
            }
            
        }
        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Marka Güncellendi");
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Araç Silindi");
        }
    }
}
