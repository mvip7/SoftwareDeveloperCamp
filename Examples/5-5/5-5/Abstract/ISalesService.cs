using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Abstract
{
    public interface ISalesService
    {
        void Sells(Games games, Users users, Campaigns campaign);
    }
}
