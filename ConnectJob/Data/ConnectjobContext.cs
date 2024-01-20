using ConnectJob.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ConnectJob.Data
{

    public class ConnectjobContext : DbContext
    {
        public  ConnectjobContext(DbContextOptions<ConnectjobContext>options) : base(options)
        {
        }
    
   
    
        public DbSet<UserModel> User {  get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasData(
                   new UserModel { Id = 1, Nome = "Rafael santos", Senha = "123123", Email = "rafaelsantos@hotmail.com", Cpf = "12312312312" },
                   new UserModel { Id = 2, Nome = "Rafael nascimento", Senha = "123123", Email = "rafaelnascimento@hotmail.com", Cpf = "12312312312" },
                   new UserModel { Id = 3, Nome = "Renato marques david", Senha = "123123", Email = "renatomdavid811@hotmail.com", Cpf = "12312312312" },
                   new UserModel { Id = 4, Nome = "Myller Tavares", Senha = "123123", Email = "myllhertavares@hotmail.com", Cpf = "12312312312" },
                   new UserModel { Id = 5, Nome = "stefany marques",Senha = "123123", Email = "stefanymarques@hotmail.com", Cpf = "12312312312" },
                   new UserModel { Id = 6, Nome = "Thales Sampaio", Senha = "123123", Email = "thalessampaio@hotmail.com", Cpf = "12312312312" }

            );
        }

    }
}
