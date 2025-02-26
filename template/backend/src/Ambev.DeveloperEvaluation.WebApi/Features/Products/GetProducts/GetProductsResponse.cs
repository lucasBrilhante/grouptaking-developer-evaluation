using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

/// <summary>
/// API response model for GetProducts operation
/// </summary>
public class GetProductsResponse
{
    /// <summary>
    /// The list of products retrieved
    /// </summary>
    List<GetProductResponse> products { get; set; }
}

