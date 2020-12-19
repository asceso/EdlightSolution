using System.Threading.Tasks;
using DatabaseModels;
using EdlightDataClient;

namespace DatabaseServices
{
    public static class UsersService
    {
        public static async Task<UserModel> GetUserByLogin(string login)
            => await EdlightProxy.Execute(client => client.GetUserByLogin(login));
    }
}
