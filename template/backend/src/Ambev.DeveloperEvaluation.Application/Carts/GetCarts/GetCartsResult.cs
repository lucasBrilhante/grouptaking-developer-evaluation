using Ambev.DeveloperEvaluation.Application.Carts.GetCart;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCarts;


/// <summary>
/// Represents the response returned after successfully retrieving a list of carts.
/// </summary>
/// <remarks>
/// This response the list of retrieved cart,
/// </remarks>
public class GetCartsResult
{
    /// <summary>
    /// Gets or sets the list of carts retrieved
    /// </summary>
    public List<GetCartResult> carts { get; set; }
}

