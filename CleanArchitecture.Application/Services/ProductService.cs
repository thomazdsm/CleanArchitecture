using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetProducts());
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            return _mapper.Map<ProductViewModel>(await _productRepository.GetProductById(id));
        }

        public void AddProduct(ProductViewModel product)
        {
            _productRepository.AddProduct(_mapper.Map<Product>(product));
        }

        public void UpdateProduct(ProductViewModel product)
        {
            _productRepository.UpdateProduct(_mapper.Map<Product>(product));
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
