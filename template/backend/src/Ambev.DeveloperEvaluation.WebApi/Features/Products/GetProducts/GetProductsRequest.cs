﻿using Ambev.DeveloperEvaluation.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

/// <summary>
/// Represents a request to create a new product in the system.
/// </summary>
public class GetProductsRequest
{
    /// <summary>
    /// Gets or sets the Order in which the data will be retrieved
    /// </summary>
    public string Order { get; set; }

    /// <summary>
    /// Gets or sets the number of the Page of the data retrieved
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Gets or sets the size of the Page of the data retrieved
    /// </summary>
    public int Size { get; set; } = 10;

    /// <summary>
    /// Gets or sets the category filter
    /// </summary>
    public ProductCategory Category { get; set; }
}