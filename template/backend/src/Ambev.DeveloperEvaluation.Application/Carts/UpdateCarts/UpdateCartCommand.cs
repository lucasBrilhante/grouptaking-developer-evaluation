using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart;

/// <summary>
/// Command for creating a new cart.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a cart, 
/// including cart title, description, price, image url, category, and rating count and value. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="UpdateCartResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="UpdateCartCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class UpdateCartCommand : IRequest<UpdateCartResult>
{
    /// <summary>
    /// Gets or sets the Id of the cart.
    /// </summary>
    public Guid Id { get; set; }
   
}

