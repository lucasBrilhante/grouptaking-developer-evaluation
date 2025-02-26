using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;

/// <summary>
/// Command for retrieving a list of products.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for retrieving a list of products, 
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
    /// Gets or sets the Order in which the data will be retrieved
    /// </summary>
    public string Order { get; set; }

    /// <summary>
    /// Gets or sets the number of the Page of the data retrieved
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Gets or sets the size of the Page of the data retrieved
    /// </summary>
    public int Size { get; set; } = 10;

    /// <summary>
    /// Gets or sets the category filter
    /// </summary>
    public ProductCategory Category { get; set; }
}