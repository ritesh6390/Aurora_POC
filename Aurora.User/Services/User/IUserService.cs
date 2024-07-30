using Aurora.User.Models;
using Aurora.User.Models.User;

namespace Aurora.User.Services.User
{
    public interface IUserService
    {
        Task<UserResponseModel> GetUsersAsync(CommonPaginationModel model);
    }
}
