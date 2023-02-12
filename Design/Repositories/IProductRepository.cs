namespace Repositories;

using Models;
using DTOs;

public interface IProductRepository
{
    Task<Product> CreateAsync(ProductRequest request, User currentUser);
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync(User currentUser);
    Task<Product> UpdateAsync(int id, ProductRequest request, User currentUser);
    Task<bool> DeleteAsync(int id, User currentUser);
}