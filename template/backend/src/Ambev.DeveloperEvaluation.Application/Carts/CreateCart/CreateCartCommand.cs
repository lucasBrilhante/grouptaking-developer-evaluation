using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Command for creating a new cart.
/// </summary>
public class CreateCartCommand : IRequest<CreateCartResult>
{
    /// <summary>
    /// Gets or sets the userid of the cart
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets products inside the cart
    /// </summary>
    public List<ProductCartCommand> Products { get; set; }
}
/// <summary>
/// Represents the product inside the cart
/// </summary>
public class ProductCartCommand () 
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
