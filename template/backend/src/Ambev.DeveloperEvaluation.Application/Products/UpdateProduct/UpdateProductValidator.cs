using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductCommand that defines validation rules for product update command.
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Title: Required, must be between 3 and 100 characters
    /// - Description: Required, must be between 3 and 200 characters
    /// - Image: Required, must be between 3 and 1000 characters
    /// - Price: between 0.1 and 99999999 
    /// - RatingStars: between 0 and 5
    /// - RatingCount: between 0 99999999
    /// </remarks>
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.Title).NotEmpty().Length(3, 100);
        RuleFor(product => product.Description).NotEmpty().Length(3, 200);
        RuleFor(product => product.Image).NotEmpty().Length(3, 1000);
        RuleFor(product => product.Price).GreaterThan(0.1).LessThan(99999999);
        RuleFor(product => product.RatingStars).InclusiveBetween(0, 5);
        RuleFor(product => product.RatingCount).InclusiveBetween(0, 99999999);
        RuleFor(product => product.Category).NotEqual(ProductCategory.None);

    }
}

