using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Command for deleting a new product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for deleting a product, 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="DeleteProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="DeleteProductCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class DeleteProductCommand : IRequest<bool>
{
    /// <summary>
    /// Gets or sets the Id of the product to be deleted.
    /// </summary>
    public Guid Id { get; set; }
}