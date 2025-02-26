using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Profile for mapping between Product entity and DeleteProductResponse
/// </summary>
public class DeleteProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeleteProduct operation
    /// </summary>
    public DeleteProductProfile()
    {
        CreateMap<DeleteProductCommand, Product>();
        CreateMap<Product, DeleteProductResult>();
    }
}

