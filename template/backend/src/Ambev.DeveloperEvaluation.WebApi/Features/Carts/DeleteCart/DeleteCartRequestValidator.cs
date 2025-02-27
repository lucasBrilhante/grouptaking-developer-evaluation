using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.DeleteCart;

/// <summary>
/// Validator for DeleteCartRequest that defines validation rules for cart creation.
/// </summary>
public class DeleteCartRequestValidator : AbstractValidator<DeleteCartRequest>
{
    /// <summary>
    /// Initializes a new instance of the DeleteCartRequestValidator with defined validation rules.
    /// </summary>
    public DeleteCartRequestValidator()
    {

    }
}

