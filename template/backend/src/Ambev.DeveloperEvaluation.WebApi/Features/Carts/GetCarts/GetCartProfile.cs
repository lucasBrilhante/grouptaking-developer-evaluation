using Ambev.DeveloperEvaluation.Application.Carts.GetCart;
using Ambev.DeveloperEvaluation.Application.Carts.GetCarts;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCarts;

/// <summary>
/// Profile for mapping between Application and API GetCart responses
/// </summary>
public class GetCartsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetCart feature
    /// </summary>
    public GetCartsProfile()
    {
        CreateMap<GetCartsRequest, GetCartsCommand>();
        CreateMap<GetCartsResult, GetCartsResponse>();
    }
}

