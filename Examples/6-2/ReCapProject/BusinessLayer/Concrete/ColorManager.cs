using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByID(int Id)
        {
            return _colorDal.Get(c => c.Id == Id);
        }
        public void Add(Color color)
        {
            if (color.Id==color.Id)
            {
                Console.WriteLine("Ekleme Islemi Basarisiz. Bu Renk Daha Önce Eklenmiş !!!");
            }
            else
            {
                _colorDal.Add(color);
                Console.WriteLine("Renk Ekleme İşlemi Başarılı");
            }
            
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk Silindi");
        }


    }
}
