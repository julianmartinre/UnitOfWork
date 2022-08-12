using UnitOfWork;
using UnitOfWork.Entities;

UserApplication _users = new UserApplication();

_users.Save(new User() { Username = "test", Password = "test" });
_users.Save(new User() { Username = "test1", Password = "test1" });

List<User> userList = (List<User>)_users.GetAll();

foreach (var item in userList)
{
    Console.WriteLine(item.Username + " " + item.Password);
}