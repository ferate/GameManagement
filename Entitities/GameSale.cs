using GameManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entitities
{
    public class GameSale:IEntity
    {
        public int Id { get; set; }
        public Gamer Gamer { get; set; }
        public Game Game { get; set; }
        public Campaign Campaign { get; set; }
        public double SalePrice { get; set; }
    }
}
