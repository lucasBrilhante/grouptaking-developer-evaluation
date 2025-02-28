using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart;

/// <summary>
/// Profile for mapping between Cart entity and DeleteCartResponse
/// </summary>
public class DeleteCartProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeleteCart operation
    /// </summary>
    public DeleteCartProfile()
    {
        CreateMap<DeleteCartCommand, Cart>();
        CreateMap<Cart, DeleteCartResult>();
    }
}

