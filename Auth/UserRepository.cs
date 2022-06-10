public class UserRepository : IUserRepository
{
    private List<UserDto> _users => new()
    {
        new UserDto("Admin", "123"),
        new UserDto("User", "123")
    };
    public UserDto GetUser(UserModel userModel) =>
    _users.FirstOrDefault(u =>
        string.Equals(u.UserName, userModel.UserName) &&
        string.Equals(u.Password, userModel.Password)) ??
        throw new Exception();    
}