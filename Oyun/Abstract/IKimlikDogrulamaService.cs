using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface IKimlikDogrulamaService
    {
        bool KimlikDogrula(Gamer gamer);
    }
}
