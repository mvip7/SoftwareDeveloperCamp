using Core.Utilities.Results;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByID(int Id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);

    }
}
