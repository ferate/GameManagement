using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IGameSaleService
    {
        void Add(GameSale gameSale);
        void Update(GameSale gameSale);
        void Delete(GameSale gameSale);
    }
}
