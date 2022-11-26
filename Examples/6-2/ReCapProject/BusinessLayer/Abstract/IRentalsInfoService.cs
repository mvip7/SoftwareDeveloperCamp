using Core.Utilities;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IRentalsInfoService
    {
        IResult Add(RentalsInfo rentalsInfo);
        IResult Update(RentalsInfo rentalsInfo);
        IResult Delete(RentalsInfo rentalsInfo);
        IDataResult<List<RentalsInfo>> GetAll();
    }
}
