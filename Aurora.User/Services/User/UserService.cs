using Aurora.User.Models;
using Aurora.User.Models.User;
using Aurora.User.Repository.User;

namespace Aurora.User.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        public Task<UserResponseModel> GetUsersAsync(CommonPaginationModel model)
        {
            return userRepository.GetUsersAsync(model);
        }
    }
}
