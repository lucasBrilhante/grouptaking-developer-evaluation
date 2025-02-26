using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;


/// <summary>
/// Represents the response returned after successfully retrieving a list of products.
/// </summary>
/// <remarks>
/// This response the list of retrieved product,
/// </remarks>
public class GetProductsResult
{
    /// <summary>
    /// Gets or sets the list of products retrieved
    /// </summary>
    public List<GetProductResult> products { get; set; }
}

