using ConnectJob.Models;

namespace ConnectJob.Repositorys.Interface
{
    public interface InterfaceUserRepository
    {
        Task<List<UserModel>> Allusers();
        Task<UserModel> SearchById(int id);
        Task<List<UserModel>> AddUsers(UserModel user);
    }
}
