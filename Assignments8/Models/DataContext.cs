﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignment8.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name-DataContext") { }
        
    }
}