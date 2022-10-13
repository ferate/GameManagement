using GameManagement.Abstract;
using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
