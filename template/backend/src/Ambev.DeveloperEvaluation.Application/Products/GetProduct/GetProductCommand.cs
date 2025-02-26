using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Command for retrieving a product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for retrieving a product, 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="GetProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="GetProductCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class GetProductCommand : IRequest<GetProductResult>
{
    /// <summary>
    /// Gets or sets the Id of the product to be retrieved.
    /// </summary>
    public Guid Id { get; set; }
}