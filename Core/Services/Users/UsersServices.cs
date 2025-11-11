using Common.Models.Results;
using Common.Models.Users;
using Core.Interfaces.Users;
using Infraestructura.Interfaces.Users;

namespace Core.Services.Users
{
    public class UsersServices(IUsersRepository repository) : IUsersServices
    {
        public async Task<OperationResults<List<User>?>> GetAllUsers()
        {
            var data = await repository.GetAllUsers();
            OperationResults<List<User>?> result = new();
            if (data is not null)
            {
                result.IsSuccess = true;
                result.Data = data;
            }
            return result;
        }

        public async Task<OperationResults<User>?> GetUserById(int Id)
        {
            var data = await repository.GetAllUsers();
            OperationResults<User>? result = new();
            if (data is not null)
            {
                result.IsSuccess = true;
                result.Data = data.FirstOrDefault(x => x.Id == Id);
            }
            return result;
        }
    }
}
