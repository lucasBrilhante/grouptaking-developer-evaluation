using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Profile for mapping between Product entity and CreateProductResponse
/// </summary>
public class DeleteProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProduct operation
    /// </summary>
    public DeleteProductProfile()
    {
        CreateMap<DeleteProductCommand, Product>();
        CreateMap<Product, DeleteProductResult>();
    }
}

