using Microsoft.EntityFrameworkCore;
using SistemadeRamais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Data
{
    public class BancoContext : DbContext
    {
        //internal object cadastro;

        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
        }
        public DbSet<CadastroModel> TAB_RAMAIS { get; set; }

       
    }
}
