using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;

/// <summary>
/// Validator for GetCartRequest that defines validation rules for cart retrieved.
/// </summary>
public class GetCartRequestValidator : AbstractValidator<GetCartRequest>
{
    /// <summary>
    /// Initializes a new instance of the GetCartRequestValidator with defined validation rules.
    /// </summary>

    public GetCartRequestValidator()
    {

    }
}

