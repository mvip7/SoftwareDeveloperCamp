using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Abstract
{
    public interface IGamesService
    {
        public void Add(Games games);
        public void Delete(Games games);
        public void Update(Games games,string newName);
    }
}
