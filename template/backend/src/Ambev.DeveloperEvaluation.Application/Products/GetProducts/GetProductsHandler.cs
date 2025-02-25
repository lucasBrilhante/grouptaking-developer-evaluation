using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Collections.Generic;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;

/// <summary>
/// Handler for processing CreateProductCommand requests
/// </summary>
public class GetProductsHandler : IRequestHandler<GetProductsCommand, GetProductsResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateProductHandler
    /// </summary>
    /// <param name="productRepository">The Product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreateProductCommand</param>
    public GetProductsHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    /// <summary>
    /// Handles the CreateProductCommand request
    /// </summary>
    /// <param name="command">The CreateProduct command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created product details</returns>
    public async Task<GetProductsResult> Handle(GetProductsCommand command, CancellationToken cancellationToken)
    {
        var validator = new GetProductsCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        List<Product>? products = await _productRepository.GetAsync(cancellationToken);
        if (products == null)
            throw new KeyNotFoundException($"User with ID {command.Id} not found");
        List<GetProductResult> mappedResponse = _mapper.Map<List<Product>, List<GetProductResult>>(products);
        return new GetProductsResult { products = mappedResponse };
    }
}

