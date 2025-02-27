using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart;

/// <summary>
/// Command for retrieving a cart.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for retrieving a cart, 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="GetCartResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="GetCartCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class GetCartCommand : IRequest<GetCartResult>
{
    /// <summary>
    /// Gets or sets the Id of the cart to be retrieved.
    /// </summary>
    public Guid Id { get; set; }
}