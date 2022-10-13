using GameManagement.Abstract;
using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Add(GameSale gameSale)
        {
            if(gameSale.Campaign!=null)
            {
                gameSale.Game.GamePrice = ApplyDiscount(gameSale.Game, gameSale.Campaign);
                Console.WriteLine("'" + gameSale.Game.GameName + "' game sold to " + gameSale.Gamer.FirstName + " " + gameSale.Gamer.LastName + " with discount");
            }
            else 
            {
                Console.WriteLine("'" + gameSale.Game.GameName + "' game sold to " + gameSale.Gamer.FirstName + " " + gameSale.Gamer.LastName + " without discount");
            }
        }

        public void Delete(GameSale gameSale)
        {            
            Console.WriteLine("Deleted the '" + gameSale.Game.GameName + "' game sale to " + gameSale.Gamer.FirstName + " " + gameSale.Gamer.LastName);           
        }

        public void Update(GameSale gameSale)
        {
            Console.WriteLine("Updated the '" + gameSale.Game.GameName + "' game sale to " + gameSale.Gamer.FirstName + " " + gameSale.Gamer.LastName);
        }

        public double ApplyDiscount(Game game,Campaign campaign)
        {
            double discountedPrice=0;
            discountedPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            return discountedPrice;
        }

    }
}
