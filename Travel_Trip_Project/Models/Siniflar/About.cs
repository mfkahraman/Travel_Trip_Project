﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
    }
}