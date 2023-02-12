namespace Repositories;

using Models;
using DTOs;

public interface IUserRepository
{
    Task<User> CreateAsync(UserRequest request, User currentUser);
    Task<User> GetByIdAsync(int id);
    Task<IEnumerable<User>> GetAllAsync(User currentUser);
    Task<User> UpdateAsync(int id, UserRequest request, User currentUser);
    Task<bool> DeleteAsync(int id, User currentUser);
}