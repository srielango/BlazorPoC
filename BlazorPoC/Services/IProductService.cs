using BlazorPoC.Models;

namespace BlazorPoC.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
    }
}