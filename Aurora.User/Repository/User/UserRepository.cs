using Aurora.User.Data;
using Aurora.User.Models;
using Aurora.User.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Aurora.User.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<UserResponseModel> GetUsersAsync(CommonPaginationModel model)
        {
            var count = await context.Users.CountAsync();
            var items = await context.Users.Skip((model.PageNumber - 1) * model.PageSize).Take(model.PageSize).ToListAsync();
            return new UserResponseModel(items, count, model.PageNumber, model.PageSize);
        }

    }
}
