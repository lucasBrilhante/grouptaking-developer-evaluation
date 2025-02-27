using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCarts;

/// <summary>
/// Validator for GetCartsRequestValidator that defines validation rules for cart retrieval.
/// </summary>
public class GetCartsRequestValidator : AbstractValidator<GetCartsRequest>
{
    /// <summary>
    /// Initializes a new instance of the GetCartsRequestValidator with defined validation rules.
    /// </summary>
    public GetCartsRequestValidator()
    {
    }
}

