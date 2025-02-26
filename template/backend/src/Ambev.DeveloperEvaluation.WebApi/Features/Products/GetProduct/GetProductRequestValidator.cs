using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// Validator for GetProductRequest that defines validation rules for product retrieved.
/// </summary>
public class GetProductRequestValidator : AbstractValidator<GetProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the GetProductRequestValidator with defined validation rules.
    /// </summary>

    public GetProductRequestValidator()
    {

    }
}

