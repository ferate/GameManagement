﻿using GameManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Entitities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
