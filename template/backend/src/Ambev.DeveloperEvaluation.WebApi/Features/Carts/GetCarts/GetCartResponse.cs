using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCarts;

/// <summary>
/// API response model for GetCarts operation
/// </summary>
public class GetCartsResponse
{
    /// <summary>
    /// The list of carts retrieved
    /// </summary>
    List<GetCartResponse> carts { get; set; }
}

