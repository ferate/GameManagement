using GameManagement.Abstract;
using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class CampaignManager : ICampaignService
    {
       public void Add(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.CampaignName + "' campaign added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.CampaignName + "' campaign deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.CampaignName + "' campaign updated");
        }
    }
}
