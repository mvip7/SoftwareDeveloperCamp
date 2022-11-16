using _5_5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Entities
{
    public class SalesManager : ISalesService
    {
        public void Sells(Games games, Users users, Campaigns campaign = null)
        {
            if (campaign==null)
            {
                Console.WriteLine("{0} {1} , {2} İsimli Oyunu {3} TL'ye Satın Alınmıştır ",
                    users.Name,users.LastName,games.Name,games.Price);
            }
            else
            {
                double calculator = games.Price - ((games.Price * campaign.DiscountRate) / 100);
                Console.WriteLine("{0} {1} İsimli Oyuncu, {2} Oyununu {3} Kampanyasından %{4} indirim ile {5} TL'ye Satın Alınmıştır ",
                    users.Name, users.LastName,games.Name,campaign.CampaignName,campaign.DiscountRate,calculator.ToString());
            }
        }
    }
}
