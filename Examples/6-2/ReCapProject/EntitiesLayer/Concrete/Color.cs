using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Color:IEntity
    {
        
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
