using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart;


/// <summary>
/// Represents the response returned after successfully deleting a new cart.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly deleted cart,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class DeleteCartResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly deleted cart.
    /// </summary>
    /// <value>A GUID that uniquely identifies the deleted cart in the system.</value>
    public Guid? Id { get; set; }
  
}

