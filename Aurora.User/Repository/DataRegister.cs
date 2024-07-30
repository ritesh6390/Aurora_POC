using Aurora.User.Repository.User;

namespace Aurora.User.Repository
{
    public class DataRegister
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dataDictionary = new Dictionary<Type, Type>
            {
                { typeof(IUserRepository), typeof(UserRepository) }
            };
            return dataDictionary;
        }
    }
}
