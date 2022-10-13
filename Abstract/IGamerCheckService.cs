using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
