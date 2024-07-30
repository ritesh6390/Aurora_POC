using Aurora.User.Models;
using Aurora.User.Models.User;

namespace Aurora.User.Repository.User
{
    public interface IUserRepository
    {
        Task<UserResponseModel> GetUsersAsync(CommonPaginationModel model);
    }


}
