namespace Services;

using Models;
using DTOs;

public interface ICategoryService
{
    Task<Category> CreateAsync(CategoryRequest request, User currentUser);
    Task<Category> GetByIdAsync(int id);
    Task<IEnumerable<Category>> GetAllAsync(User currentUser);
    Task<Category> UpdateAsync(int id, CategoryRequest request, User currentUser);
    Task<bool> DeleteAsync(int id, User currentUser);

    Task<IEnumerable<Category>> GetProductsByCategory(int id);
}