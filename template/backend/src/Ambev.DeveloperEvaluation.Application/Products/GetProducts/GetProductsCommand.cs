using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;

/// <summary>
/// Command for creating a new product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a product, 
/// including product title, description, price, image url, category, and rating count and value. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="GetProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="GetProductCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class GetProductsCommand : IRequest<GetProductsResult>
{
    /// <summary>
    /// Gets or sets the Title of the product to be created. Must not be null or empty and have length between 3 and 100. 
    /// </summary>
    public Guid Id { get; set; }
}