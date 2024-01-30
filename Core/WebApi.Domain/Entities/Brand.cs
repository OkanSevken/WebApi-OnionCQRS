﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Cammon;

namespace WebApi.Domain.Entities
{
    public class Brand : EntityBase
    {
        public Brand() 
        {

        }
        public Brand(string name) 
        {
            Name = name;
        }
        public string Name { get; set; }
        //public ICollection<Product> Products { get; set; }
    }
}
