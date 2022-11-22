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
            return _colorDal.Get(c=>c.ColorID==Id);
        }

       
    }
}
