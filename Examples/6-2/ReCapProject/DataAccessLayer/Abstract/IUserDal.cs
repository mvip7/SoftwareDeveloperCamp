using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepos<User>
    {
    }
}
