using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;

/// <summary>
/// Represents a request to create a new cart in the system.
/// </summary>
public class GetCartRequest
{
    /// <summary>
    /// Gets or sets the Id of the cart to be retrived.
    /// </summary>
    public Guid Id { get; set; }
}