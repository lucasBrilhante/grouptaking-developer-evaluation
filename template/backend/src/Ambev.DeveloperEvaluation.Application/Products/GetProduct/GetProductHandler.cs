using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Handler for processing GetProductCommand requests
/// </summary>
public class GetProductHandler : IRequestHandler<GetProductCommand, GetProductResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetProductHandler
    /// </summary>
    /// <param name="productRepository">The Product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetProductCommand</param>
    public GetProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    /// <summary>
    /// Handles the GetProductCommand request
    /// </summary>
    /// <param name="command">The GetProduct command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The retrieved product details</returns>
    public async Task<GetProductResult> Handle(GetProductCommand command, CancellationToken cancellationToken)
    {
        var validator = new GetProductCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var product = await _productRepository.GetByIdAsync(command.Id, cancellationToken);
        if (product == null)
            throw new KeyNotFoundException($"User with ID {command.Id} not found");

        return _mapper.Map<GetProductResult>(product);
    }
}

