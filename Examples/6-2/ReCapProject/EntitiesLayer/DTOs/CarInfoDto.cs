using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.DTOs
{
    public class CarInfoDto
    {
        public int CarID{ get; set; }
        public string ColorName{ get; set; }
        public string BrandName{ get; set; }
        public decimal DailyPrice{ get; set; }
    }
}
