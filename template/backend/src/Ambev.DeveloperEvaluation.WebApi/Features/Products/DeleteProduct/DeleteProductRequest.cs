using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// Represents a request to create a new product in the system.
/// </summary>
public class DeleteProductRequest
{
    /// <summary>
    /// Gets or sets the Title of the product to be created. Must not be null or empty and have length between 3 and 100. 
    /// </summary>
    public Guid Id { get; set; }
}