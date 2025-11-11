using System.Net.Http.Json;
using Common.Models.Users;
using Infraestructura.Interfaces.Users;

namespace Infraestructura.Services.Users
{
    public class UsersRepository(HttpClient httpClient) : IUsersRepository
    {
        public async Task<List<User>?> GetAllUsers()
        {
            return await httpClient.GetFromJsonAsync<List<User>>("users") ?? null;
        }
    }
}
