using Core.Utilities.Results;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
