﻿using Core.Utilities;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
