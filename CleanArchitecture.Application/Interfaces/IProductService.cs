using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
        Task<ProductViewModel> GetProductById(int id);

        void AddProduct(ProductViewModel product);
        void UpdateProduct(ProductViewModel product);
        void DeleteProduct(int id);
    }
}
