﻿using GameManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entitities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public double GamePrice { get; set; }
    }
}
