namespace Aurora.User.Models.User
{
    public class UserResponseModel : CommonPaginationModel
    {
        public List<Users> Users { get; set; }
        public int TotalCount { get; set; }
        public UserResponseModel(List<Users> users, int totalCount, int pageNumber, int pageSize)
        {
            Users = users;
            TotalCount = totalCount;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
