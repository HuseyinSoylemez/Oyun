using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Entities
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }

        public DateTime SaleDate { get; set; }

        public double Price { get; set; }
    }
}
