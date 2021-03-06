﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADWORDS.Models
{
    public class UpdateContext : DbContext
    {
        public UpdateContext(DbContextOptions<UpdateContext> options) : base(options) { }

        public DbSet<Update> Updates { get; set; }

    }
}
