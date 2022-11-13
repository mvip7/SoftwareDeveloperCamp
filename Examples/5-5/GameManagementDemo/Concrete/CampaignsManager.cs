using _5_5.Abstract;
using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Concrete
{
    public class CampaignsManager : ICampaignsService
    {
        public void AddCampaign(Campaigns campaign)
        {
            Console.WriteLine("{0} İsimli Kampanya, Listeye Eklendi !!!",campaign.CampaignName);
        }

        public void DeleteCampaign(Campaigns campaign)
        {
            Console.WriteLine("{0} İsimli Kampanya Silindi !!!", campaign.CampaignName);
        }

        public void IntegrateCampaign(Games game, Campaigns campaign)
        {
            Console.WriteLine("{0} İsimli Kampanya, {1} İsimli Oyun İçin Uygulandı !!!", campaign.CampaignName,game.Name);
        }

        public void UpdateCampaign(Campaigns campaign)
        {
            Console.WriteLine("{0} İsimli Kampanya Güncellendi !!!",campaign.CampaignName);
        }
    }
}
