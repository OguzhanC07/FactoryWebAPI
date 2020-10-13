﻿using FactoryWebAPI.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryWebAPI.Entities.Concrete
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }


        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
