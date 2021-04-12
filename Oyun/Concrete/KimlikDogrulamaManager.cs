using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public class KimlikDogrulamaManager : IKimlikDogrulamaService
    {
        public bool KimlikDogrula(Gamer gamer)
        {
            return true;
        }
    }
}
