using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Models.Entities;

namespace merketoaspnet.Helpers.Services;

public class ProductService
{
# region constructors + private fields
    private readonly ProductRepo _productRepository;

    public ProductService(ProductRepo productRepository)
    {
        _productRepository = productRepository;
    }

    #endregion


    public async Task CreateAsync(ProductEntity productEntity)
    {
        await _productRepository.AddAsync(productEntity);
    }
}

