using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest that defines validation rules for product creation.
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
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
    public CreateProductRequestValidator()
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

