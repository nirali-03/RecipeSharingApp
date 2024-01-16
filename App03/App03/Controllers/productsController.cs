﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App03.Data;
using App03.Models;

namespace App03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly App03Context _context;

        public productsController(App03Context context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<products>>> Getproducts()
        {
            return await _context.products.ToListAsync();
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<products>> Getproducts(int id)
        {
            var products = await _context.products.FindAsync(id);

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // PUT: api/products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putproducts(int id, products products)
        {
            if (id != products.Id)
            {
                return BadRequest();
            }

            _context.Entry(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<products>> Postproducts(products products)
        {
            _context.products.Add(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getproducts", new { id = products.Id }, products);
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteproducts(int id)
        {
            var products = await _context.products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _context.products.Remove(products);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool productsExists(int id)
        {
            return _context.products.Any(e => e.Id == id);
        }
    }
}
