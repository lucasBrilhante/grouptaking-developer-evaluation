using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart;

/// <summary>
/// Command for deleting a new cart.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for deleting a cart, 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="DeleteCartResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="DeleteCartCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class DeleteCartCommand : IRequest<bool>
{
    /// <summary>
    /// Gets or sets the Id of the cart to be deleted.
    /// </summary>
    public Guid Id { get; set; }
}