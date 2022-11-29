using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IServices
    {
        IDataResult<List<IEntity>> GetAll();
        IDataResult<IEntity> GetByID(int Id);
        IResult Add(IEntity entity);
        IResult Update(IEntity entity);
        IResult Delete(IEntity entity);
    }
}
