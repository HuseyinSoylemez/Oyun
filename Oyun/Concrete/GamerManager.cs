using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{

    public class GamerManager : IGamerService
    {
        private IKimlikDogrulamaService _kimlikDogrulamaService;

        public GamerManager(IKimlikDogrulamaService kimlikDogrulamaService)
        {
            _kimlikDogrulamaService = kimlikDogrulamaService;
        }
        public void Add(Gamer gamer)
        {
            if (_kimlikDogrulamaService.KimlikDogrula(gamer))
            {
                Console.WriteLine("Kişi doğrulandı. '{0}' eklendi", gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Kişi doğrulanmadı. '{0}' eklenemedi", gamer.FirstName);
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Oyuncu güncellendi");
        }
    }
}
