using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetByID(int Id);
    }
}
