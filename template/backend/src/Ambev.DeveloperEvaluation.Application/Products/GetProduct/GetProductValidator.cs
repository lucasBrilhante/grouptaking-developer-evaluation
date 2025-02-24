using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for product creation command.
/// </summary>
public class GetProductCommandValidator : AbstractValidator<GetProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
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
    public GetProductCommandValidator()
    {
    }
}

