using GameManagement.Adapters;
using GameManagement.Concrete;
using GameManagement.Entitities;
using System;

namespace GameManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());            
            Gamer gamer = new Gamer() { Id = 1, FirstName = "FERAT", LastName = "EFİL", NationalityId = "15665454548", DateOfBirth = new DateTime(1981, 09, 01), UserName = "ferate", Password = "1234" };
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine("*********************************");

            GameManager gameManager = new GameManager();
            Game game = new Game() { Id = 1, GameName = "Learn Software Development with Game", GameDescription = "No Description", GamePrice = 100 };
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            Console.WriteLine("*********************************");

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign() { Id=1, CampaignName= "New Year Campaign", CampaignStartDate = new DateTime(2022, 12, 01), CampaignEndDate = new DateTime(2022, 12, 31), DiscountRate = 25 };
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("*********************************");

            GameSaleManager gameSaleManager = new GameSaleManager();
            GameSale gameSale = new GameSale();
            gameSale.Id = 1;
            gameSale.Gamer = gamer;
            gameSale.Game = game;
            gameSale.Campaign = campaign;            
            gameSale.SalePrice = game.GamePrice;
            gameSaleManager.Add(gameSale);
            gameSaleManager.Update(gameSale);
            gameSaleManager.Delete(gameSale);

        }
    }
}
