using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiPage.Models;

namespace MultiPage.Data
{
    public class MultiPageContext : DbContext
    {
        public MultiPageContext (DbContextOptions<MultiPageContext> options)
            : base(options)
        {
        }

        public DbSet<MultiPage.Models.Contact> Contacts { get; set; }
    }
}
