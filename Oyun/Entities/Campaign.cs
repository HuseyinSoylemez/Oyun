using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CapmpaignDiscount { get; set; }
    }
}
