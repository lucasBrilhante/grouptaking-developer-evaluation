using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCarts;

/// <summary>
/// Profile for mapping between Cart entity and GetCartResponse
/// </summary>
public class GetCartsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetCart operation
    /// </summary>
    public GetCartsProfile()
    {
        CreateMap<GetCartsCommand, Cart>();
        CreateMap<Cart, GetCartsResult>();
    }
}

