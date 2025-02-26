using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;
using Ambev.DeveloperEvaluation.Application.Products.GetProducts;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;
using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;
using Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products;

/// <summary>
/// Controller for managing Product operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ProductsController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public ProductsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }


    /// <summary>
    /// Creates a new Product
    /// </summary>
    /// <param name="request">The product creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created product details</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateProductResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateProductRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateProductCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateProductResponse>
        {
            Success = true,
            Message = "Product created successfully",
            Data = _mapper.Map<CreateProductResponse>(response)
        });
    }

    /// <summary>
    /// Retrieves a product by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the product</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product details if found</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetProductResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProduct([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new GetProductRequest { Id = id };
        var validator = new GetProductRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetProductCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetProductResponse>
        {
            Success = true,
            Message = "Product retrieved successfully",
            Data = _mapper.Map<GetProductResponse>(response)
        });
    }

    /// <summary>
    /// Retrieves all products
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product details if found</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResponseWithData<List<GetProductResponse>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProducts(CancellationToken cancellationToken,
        [FromQuery] string _order,
        [FromQuery] int _page = 1,
        [FromQuery] int _size = 10)
    {
        var request = new GetProductsRequest
        {
            Order = _order,
            Page = _page,
            Size = _size,
        };
        var validator = new GetProductsRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetProductsCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<GetProductResponse>>
        {
            Success = true,
            Message = "Product retrieved successfully",
            Data = _mapper.Map<List<GetProductResult>, List<GetProductResponse>>(response.products)
        });
    }

    /// <summary>
    /// Retrieves all products by category
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product details if found</returns>
    [HttpGet("/categories/{category}")]
    [ProducesResponseType(typeof(ApiResponseWithData<List<GetProductResponse>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProductsByCategory(
        [FromRoute] ProductCategory category, 
        CancellationToken cancellationToken,
        [FromQuery] string _order,
        [FromQuery] int _page = 1,
        [FromQuery] int _size = 10)
    { 
        var request = new GetProductsRequest 
        { 
            Order = _order,
            Page = _page,
            Size = _size,
            Category = category

        };
        var validator = new GetProductsRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetProductsCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<GetProductResponse>>
        {
            Success = true,
            Message = "Product retrieved successfully",
            Data = _mapper.Map<List<GetProductResult>, List<GetProductResponse>>(response.products)
        });
    }

    /// <summary>
    /// Update a Product
    /// </summary>
    /// <param name="id">The unique identifier of the product</param>
    /// <param name="request">The product creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated product details</returns>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<UpdateProductResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, [FromBody] UpdateProductRequest request, CancellationToken cancellationToken)
    {
        var validator = new UpdateProductRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<UpdateProductCommand>(request);
        command.Id = id;
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<UpdateProductResponse>
        {
            Success = true,
            Message = "Product created successfully",
            Data = _mapper.Map<UpdateProductResponse>(response)
        });
    }
    /// <summary>
    /// Deletes a product by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the product</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A boolean that indicates sf it deleted or not</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProduct([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new DeleteProductRequest { Id = id };
        var validator = new DeleteProductRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<DeleteProductCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<bool>
        {
            Success = true,
            Message = "Product deleted successfully",   
            Data = response
        });
    }
}

