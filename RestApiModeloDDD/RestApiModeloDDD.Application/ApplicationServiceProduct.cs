using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct,
                                         IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapperListClientDto(products);
        }

        public ProductDto GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapperProduct.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Update(product);
        }
    }
}
