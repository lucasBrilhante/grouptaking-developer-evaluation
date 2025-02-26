using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// Represents a request to delete a product in the system.
/// </summary>
public class DeleteProductRequest
{
    /// <summary>
    /// Gets or sets the Id of the product to be deleted.
    /// </summary>
    public Guid Id { get; set; }
}