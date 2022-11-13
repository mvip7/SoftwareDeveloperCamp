using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Abstract
{
    interface ICampaignsService
    {
        void AddCampaign(Campaigns campaign);
        void DeleteCampaign(Campaigns campaign);
        void UpdateCampaign(Campaigns campaign);
        void IntegrateCampaign(Games game, Campaigns campaign);
    }
}
