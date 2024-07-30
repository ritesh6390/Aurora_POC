using Aurora.User.Services.User;

namespace Aurora.User.Services
{
    public class ServiceRegister
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var serviceDictonary = new Dictionary<Type, Type>
            {
                { typeof(IUserService), typeof(UserService) }
            };
            return serviceDictonary;
        }
    }
}
