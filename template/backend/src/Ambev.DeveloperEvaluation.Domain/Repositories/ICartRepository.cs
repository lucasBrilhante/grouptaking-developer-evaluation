﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Cart entity operations
    /// </summary>
    public interface ICartRepository
    {
        /// <summary>
        /// Creates a new cart in the repository
        /// </summary>
        /// <param name="cart">The cart to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created cart</returns>
        Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves carts in the repository
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The cart if found, null otherwise</returns>
        Task<List<Cart>?> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a cart by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the cart</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The cart if found, null otherwise</returns>
        Task<Cart?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a cart in the repository
        /// </summary>
        /// <param name="cart">The cart to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated cart</returns>
        Task<Cart> UpdateAsync(Cart cart, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a cart from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the cart to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the cart was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
