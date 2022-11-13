using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Interfaces
{
    public interface IUserService
    {
        public void Add(Users users);
        public void Update(Users users,string firstName,string lastName);
        public void Delete(Users users);
    }
}
