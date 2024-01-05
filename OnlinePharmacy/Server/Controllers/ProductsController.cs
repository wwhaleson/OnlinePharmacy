﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Server.Data;
using OnlinePharmacy.Server.IRepository;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _unitOfWork.Products.GetAll();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return BadRequest();
            }

            _unitOfWork.Products.Update(product);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _unitOfWork.Products.Insert(product);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProduct", new { id = product.ProductID }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            await _unitOfWork.Products.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();

        }

        private async Task<bool> ProductExists(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.ProductID == id);
            return product != null;
        }
    }
}
