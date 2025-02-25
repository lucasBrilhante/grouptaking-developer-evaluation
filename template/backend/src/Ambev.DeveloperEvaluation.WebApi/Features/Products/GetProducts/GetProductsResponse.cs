using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

/// <summary>
/// API response model for CreateProduct operation
/// </summary>
public class GetProductsResponse
{
    /// <summary>
    /// The unique identifier of the created product
    /// </summary>
    List<GetProductResponse> products { get; set; }
}

