using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Collections.Generic;
using Ambev.DeveloperEvaluation.Application.Carts.GetCart;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCarts;

/// <summary>
/// Handler for processing GetCartCommand requests
/// </summary>
public class GetCartsHandler : IRequestHandler<GetCartsCommand, GetCartsResult>
{
    private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetCartHandler
    /// </summary>
    /// <param name="cartRepository">The Cart repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetCartCommand</param>
    public GetCartsHandler(ICartRepository cartRepository, IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }
    /// <summary>
    /// Handles the GetCartCommand request
    /// </summary>
    /// <param name="command">The GetCart command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The retrieved cart details</returns>
    public async Task<GetCartsResult> Handle(GetCartsCommand command, CancellationToken cancellationToken)
    {
        var validator = new GetCartsCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        List<Cart>? carts = await _cartRepository.GetAsync(cancellationToken);

        List<GetCartResult> mappedResponse = _mapper.Map<List<Cart>, List<GetCartResult>>(carts);
        return new GetCartsResult { carts = mappedResponse };
    }
}

