using GameManagement.Abstract;
using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( "'"+game.GameName+ "' game added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("'" + game.GameName + "' game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("'" + game.GameName + "' game updated");
        }
    }
}
