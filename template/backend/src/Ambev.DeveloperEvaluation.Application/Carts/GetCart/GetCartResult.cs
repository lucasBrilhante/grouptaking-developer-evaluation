using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart;


/// <summary>
/// Represents the response returned after successfully retrieving a new cart.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly retrieved cart,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class GetCartResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly retrieved cart.
    /// </summary>
    /// <value>A GUID that uniquely identifies the retrieved cart in the system.</value>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the userid of the cart
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets products inside the cart
    /// </summary>
    public List<ProductCartResult> Products { get; set; }
}
/// <summary>
/// Represents the product inside the cart
/// </summary>
public class ProductCartResult()
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
   

