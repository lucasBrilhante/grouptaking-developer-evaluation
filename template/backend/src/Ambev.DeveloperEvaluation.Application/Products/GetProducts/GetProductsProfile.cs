using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;

/// <summary>
/// Profile for mapping between Product entity and CreateProductResponse
/// </summary>
public class GetProductsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProduct operation
    /// </summary>
    public GetProductsProfile()
    {
        CreateMap<GetProductsCommand, Product>();
        CreateMap<Product, GetProductsResult>();
    }
}

