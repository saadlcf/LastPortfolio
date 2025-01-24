using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaadPortfolio.Models;

namespace LastPortfolio.Data
{
    public class LastPortfolioContext : DbContext
    {
        public LastPortfolioContext (DbContextOptions<LastPortfolioContext> options)
            : base(options)
        {
        }

        public DbSet<SaadPortfolio.Models.Experience> Experience { get; set; } = default!;
        public DbSet<SaadPortfolio.Models.Message> Message { get; set; } = default!;
        public DbSet<SaadPortfolio.Models.Project> Project { get; set; } = default!;
        public DbSet<SaadPortfolio.Models.Skill> Skill { get; set; } = default!;
    }
}
