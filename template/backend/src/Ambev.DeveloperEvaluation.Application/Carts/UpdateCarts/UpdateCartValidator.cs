using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart;

/// <summary>
/// Validator for UpdateCartCommand that defines validation rules for cart update command.
/// </summary>
public class UpdateCartCommandValidator : AbstractValidator<UpdateCartCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateCartCommandValidator with defined validation rules.
    /// </summary>

    public UpdateCartCommandValidator()
    {

    }
}

