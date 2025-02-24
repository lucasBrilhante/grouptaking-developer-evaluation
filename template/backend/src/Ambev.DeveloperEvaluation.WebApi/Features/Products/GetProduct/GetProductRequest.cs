using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// Represents a request to create a new product in the system.
/// </summary>
public class GetProductRequest
{
    /// <summary>
    /// Gets or sets the Title of the product to be created. Must not be null or empty and have length between 3 and 100. 
    /// </summary>
    public Guid Id { get; set; }
}