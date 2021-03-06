﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EDUN.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDUN.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Category> Categories { get; set; }
        Task SaveChangesAsync();
    }
}
