using Oyun.Adapter;
using Oyun.Concrete;
using Oyun.Entities;
using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {Id=1,GameName="Saklanma",GamePrice=30.00 };
            Game game2 = new Game() { Id = 2, GameName = "Yakalama", GamePrice = 50.00 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);

            Console.WriteLine("-----------------------------------------------------");
            Gamer gamer1 = new Gamer
            {
                Id=1,
                NationalityId = "11111111111",
                FirstName = "Ahmet",
                LastName = "Erkul",
                DateOfBirth = new DateTime(1985,6,1)
            };
            Gamer gamer2 = new Gamer
            {
                Id=2,
                NationalityId = "12121212121",
                FirstName = "Hüseyin",
                LastName = "Söylemez",
                DateOfBirth = new DateTime(1981, 4, 4)
            };
            GamerManager gamerManager = new GamerManager(new KimlikDogrulamaManager());
            gamerManager.Add(gamer1);
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer2);

            Console.WriteLine("-----------------------------------------------------");

            Campaign campaign = new Campaign
            {
                Id=1,
                CampaignName = "BÜüyük Bahar",
                CapmpaignDiscount = 30
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Console.WriteLine();
            Console.WriteLine("------------------------- S A T I Ş ----------------------------");
            Console.WriteLine();

            SalesManager salesManager = new SalesManager();
            salesManager.SalesGame(gamer1, game1, campaign);


        }
    }
}
