﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Books.API.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
    }
}
