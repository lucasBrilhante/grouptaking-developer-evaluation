using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// Validator for DeleteProductRequest that defines validation rules for product creation.
/// </summary>
public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the DeleteProductRequestValidator with defined validation rules.
    /// </summary>
    public DeleteProductRequestValidator()
    {

    }
}

