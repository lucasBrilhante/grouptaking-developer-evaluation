using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DefaultContext _context;
        private static readonly string _ID_NOT_FOUND = "Id not found";
        private static readonly string _EXECUTION_FAILED = "Execution failed";
        /// <summary>
        /// Initializes a new instance of CartRepository
        /// </summary>
        /// <param name="context">The database context</param>
        public CartRepository(DefaultContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new cart in the repository
        /// </summary>
        /// <param name="cart">The cart to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created cart</returns>
        public async Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken = default)
        {
            await _context.Carts.AddAsync(cart, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return cart;
        }

        /// <summary>
        /// Retrieves carts in the repository
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The cart if found, null otherwise</returns>
        public async Task<List<Cart>?> GetAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Carts.ToListAsync();
        }

        /// <summary>
        /// Retrieves a cart by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the cart</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The cart if found, null otherwise</returns>
        public async Task<Cart?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Carts.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        /// <summary>
        /// Update a cart in the repository
        /// </summary>
        /// <param name="cart">The cart to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated cart</returns>
        public async Task<Cart> UpdateAsync(Cart cart, CancellationToken cancellationToken = default)
        {

            var entity = await GetByIdAsync(cart.Id, cancellationToken);
            //if (entity == null)
                //return false;
            //entity.Title = cart.Title;
            _context.Carts.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return cart;
        }

        /// <summary>
        /// Deletes a cart from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the cart to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the cart was deleted, false if not found</returns>
        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var cart = await GetByIdAsync(id, cancellationToken);
            if (cart == null)
                return false;

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
