using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public class SalesManager : ISalesService
    {
        public void SalesGame(Gamer gamer, Game game, Campaign campaign)
        {
            double price;
            if (campaign.CapmpaignDiscount!=0)
            {
                price = game.GamePrice - (game.GamePrice*campaign.CapmpaignDiscount/100);
            }
            else
            {
                price = game.GamePrice;
            }

            Console.WriteLine("'{0}' oyunu '{1}' a '{2}' kampanyası ile {3} '$' karşılığında  satıldı", game.GameName, gamer.FirstName, campaign.CampaignName, price);
        }
    }
}
