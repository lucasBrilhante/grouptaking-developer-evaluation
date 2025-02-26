using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// Represents a request to create a new product in the system.
/// </summary>
public class GetProductRequest
{
    /// <summary>
    /// Gets or sets the Id of the product to be retrived.
    /// </summary>
    public Guid Id { get; set; }
}