using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart;

/// <summary>
/// Profile for mapping between Cart entity and GetCartResponse
/// </summary>
public class GetCartProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetCart operation
    /// </summary>
    public GetCartProfile()
    {
        CreateMap<GetCartCommand, Cart>();
        CreateMap<Product, ProductCartResult>().ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.Id));

        CreateMap<Cart, GetCartResult>();
    }
}

