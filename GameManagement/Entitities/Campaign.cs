using GameManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entitities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignEndDate { get; set; }
        public double DiscountRate { get; set; }
    }
}
