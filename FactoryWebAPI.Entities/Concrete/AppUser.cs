﻿using FactoryWebAPI.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryWebAPI.Entities.Concrete
{
    public class AppUser : ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public int BanCount { get; set; }
        public DateTime BanEndTime { get; set; } = DateTime.Now;


        public List<Dealer> Dealers { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }
        public List<ForgotPassword> AppUserForgotPasswords { get; set; }
    }
}
