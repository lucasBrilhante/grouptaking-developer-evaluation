using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Validator for CreateCartCommand that defines validation rules for cart creation command.
/// </summary>
public class CreateCartCommandValidator : AbstractValidator<CreateCartCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateCartCommandValidator with defined validation rules.
    /// </summary>
    public CreateCartCommandValidator()
    {


    }
}

