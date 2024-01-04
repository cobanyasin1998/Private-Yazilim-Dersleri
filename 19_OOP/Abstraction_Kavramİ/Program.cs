
UserService userService = new UserService();//Abstraction uygulanmadı.
userService.ValidateUser(new UserInfo());

IUserValidateService userValidateService = userService;//Abstraction uygulandı.
userValidateService.ValidateUser(new UserInfo());

//Ana hedefi => Abstraction amacı, geliştirciden bir sınıfa karşın olabilecek
//gereksiz ayrıntıları gizlemek ve sadece gerekli olanları göstermektir.

interface IUserValidateService
{
    bool ValidateUser(UserInfo userInfo);
}

class UserService: IUserValidateService
{
    public void CreateUser(UserInfo userInfo)
    {
        //...
    }
    public void RemoveUser(int userId)
    {
        //...
    }
    public List<User>? Users { get; set; }
    public bool ValidateUser(UserInfo userInfo)
    {
        //...
        return true;
    }
}
class UserInfo
{

}
class User
{

}