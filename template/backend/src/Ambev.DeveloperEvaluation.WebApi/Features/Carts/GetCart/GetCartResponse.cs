using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;

/// <summary>
/// API response model for CreateCart operation
/// </summary>
public class GetCartResponse
{
    /// <summary>
    /// Gets or sets the userid of the cart
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets the userid of the cart
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets products inside the cart
    /// </summary>
    public List<ProductCartResponse> Products { get; set; }
}

public class ProductCartResponse()
{
    /// <summary>
    /// Gets or sets the product id of the product.
    /// </summary>
    public Guid ProductId { get; set; }
    /// <summary>
    /// Gets or sets the quantity of the product.
    /// </summary>
    public int Quantity { get; set; }
}