using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart;

/// <summary>
/// Handler for processing DeleteCartCommand requests
/// </summary>
public class DeleteCartHandler : IRequestHandler<DeleteCartCommand, bool>
{
    private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of DeleteCartHandler
    /// </summary>
    /// <param name="cartRepository">The Cart repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for DeleteCartCommand</param>
    public DeleteCartHandler(ICartRepository cartRepository, IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }
    /// <summary>
    /// Handles the DeleteCartCommand request
    /// </summary>
    /// <param name="command">The DeleteCart command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The deleted cart details</returns>
    public async Task<bool> Handle(DeleteCartCommand command, CancellationToken cancellationToken)
    {
        var validator = new DeleteCartCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var result = await _cartRepository.DeleteAsync(command.Id, cancellationToken);

        return result;
    }
}

