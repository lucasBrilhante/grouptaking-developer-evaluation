using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

/// <summary>
/// Validator for GetProductsRequestValidator that defines validation rules for product retrieval.
/// </summary>
public class GetProductsRequestValidator : AbstractValidator<GetProductsRequest>
{
    /// <summary>
    /// Initializes a new instance of the GetProductsRequestValidator with defined validation rules.
    /// </summary>
    public GetProductsRequestValidator()
    {
    }
}

