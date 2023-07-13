using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace gnk_invest_test.Models
{
    public class InvestDatacontext : DbContext
    {
        public InvestDatacontext(DbContextOptions<InvestDatacontext> options) : base(options)
        {
        }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorIndividual> ContractorIndividuals { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }
}
