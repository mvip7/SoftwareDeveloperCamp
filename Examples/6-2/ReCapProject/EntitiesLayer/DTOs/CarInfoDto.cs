using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.DTOs
{
    public class CarInfoDto:IDto
    {
        public int CarId{ get; set; }
        public string Color{ get; set; }
        public string Brand{ get; set; }
        public int DailyPrice{ get; set; }
    }
}
