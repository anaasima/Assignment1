using FINALAssignment.Models;

namespace FINALAssignment.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
        User CreateUser(string name, string username, string password, int id);
    }
}