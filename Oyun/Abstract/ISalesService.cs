using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface ISalesService
    {
        void SalesGame(Gamer gamer, Game game, Campaign campaign);
    }
}
