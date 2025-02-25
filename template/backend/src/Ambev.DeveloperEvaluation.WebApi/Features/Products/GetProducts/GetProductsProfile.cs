using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Application.Products.GetProducts;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

/// <summary>
/// Profile for mapping between Application and API CreateProduct responses
/// </summary>
public class GetProductsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProduct feature
    /// </summary>
    public GetProductsProfile()
    {
        CreateMap<GetProductsRequest, GetProductsCommand>();
        CreateMap<GetProductsResult, GetProductsResponse>();
    }
}

