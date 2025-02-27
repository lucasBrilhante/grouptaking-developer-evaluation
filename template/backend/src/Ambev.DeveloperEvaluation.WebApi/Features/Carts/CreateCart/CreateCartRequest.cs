namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// Represents a request to create a new cart in the system.
/// </summary>
public class CreateCartRequest
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
public class ProductCartCommand()
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