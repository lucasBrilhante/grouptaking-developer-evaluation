using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Command for creating a new product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a product, 
/// including product title, description, price, image url, category, and rating count and value. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="UpdateProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="UpdateProductCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class UpdateProductCommand : IRequest<UpdateProductResult>
{
    /// <summary>
    /// Gets or sets the Id of the product.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets the Title of the product to be updated.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Price of the product to be updated.
    /// </summary>
    public double Price { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Description of the product to be updated.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Category of the product to be updated.
    /// </summary>
    public ProductCategory Category { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Image of the product to be updated.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the RatingCount of the product to be updated.
    /// </summary>
    public int RatingCount { get; set; } = 0;

    /// <summary>
    /// Gets or sets the RatingStars of the product to be updated.
    /// </summary>
    public float RatingStars { get; set; } = 0;

    public ValidationResultDetail Validate()
    {
        var validator = new UpdateProductCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}

