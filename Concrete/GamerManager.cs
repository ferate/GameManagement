using GameManagement.Abstract;
using GameManagement.Adapters;
using GameManagement.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    public class GamerManager : IGamerService
    {

        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {           
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer " + gamer.FirstName + " " + gamer.LastName + " added with Mernis verification");
            }
            else
            {
                Console.WriteLine("Mernis Verification Failed. Please Check Personal Information.");
            }            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName+" "+gamer.LastName+ " deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " " + gamer.LastName + " updated");
        }
    }
}
