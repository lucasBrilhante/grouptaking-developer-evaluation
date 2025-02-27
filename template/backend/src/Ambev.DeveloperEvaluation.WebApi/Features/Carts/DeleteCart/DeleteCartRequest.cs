using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.DeleteCart;

/// <summary>
/// Represents a request to delete a cart in the system.
/// </summary>
public class DeleteCartRequest
{
    /// <summary>
    /// Gets or sets the Id of the cart to be deleted.
    /// </summary>
    public Guid Id { get; set; }
}