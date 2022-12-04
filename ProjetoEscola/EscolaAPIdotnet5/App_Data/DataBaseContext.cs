using EscolaAPIdotnet5.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaAPIdotnet5.App_Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> opts) : base(opts)
        {

        } 
        public DbSet<Aluno> Alunos { get; set; }
    }

   
}
