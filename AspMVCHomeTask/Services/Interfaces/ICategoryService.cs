using AspMVCHomeTask.Models;
using AspMVCHomeTask.ViewModels.Categories;

namespace AspMVCHomeTask.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync();
    }

}
