using ConnectJob.Data;
using ConnectJob.Models;
using ConnectJob.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;
using static ConnectJob.Repositorys.UserRepository;

namespace ConnectJob.Repositorys
{
    public class UserRepository : InterfaceUserRepository
    {
        private readonly ConnectjobContext _dbContext;
        public UserRepository(ConnectjobContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<UserModel>> AddUsers(UserModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> Allusers()
        {
           return await _dbContext.User.ToListAsync();
        }

        public async Task<UserModel> SearchById(int id)
        {
            var usuario = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == id);
            if (usuario == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }
            return usuario;
        }
    }
}
