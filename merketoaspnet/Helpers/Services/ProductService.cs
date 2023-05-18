using Azure;
using merketoaspnet.Contexts;
using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Models.Dtos;
using merketoaspnet.Models.Entities;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAllAsync();

        var productList = new List<Product>();
        foreach (var product in products)
        {
            var tagList = new List<string>();

            foreach (var tag in product.Tags)
                tagList.Add(tag.Tag.TagName);

            productList.Add(new Product
            {
                ArticleNumber = product.ArticleNumber,
                ProductName = product.ProductName,
                Ingress = product.Ingress,
                Description = product.Description,
                Tags = tagList,
                VendorName = product.VendorName,
                Price = product.Price
            });
        }
        return productList;

    }

    public async Task<IEnumerable<Product>> GetAllByTagNameAsync(string tagName)
    {
        var products = await _productRepository.GetAllByTagNameAsync(tagName);

        var productList = new List<Product>();
        foreach (var product in products)
        {
            var tagList = new List<string>();

            foreach (var tag in product.Tags)
                tagList.Add(tag.Tag.TagName);

            productList.Add(new Product
            {
                ArticleNumber = product.ArticleNumber,
                ProductName = product.ProductName,
                Ingress = product.Ingress,
                Description = product.Description,
                Tags = tagList,
                VendorName = product.VendorName,
                Price = product.Price
            });
        }
        return productList;

    }


}

