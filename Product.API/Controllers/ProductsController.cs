using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Concrete.Features.Products.Commands;
using Product.Business.Concrete.Features.Products.Queries;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var query =await _mediator.Send(new GetAllProductsQuery());
            return Ok(query);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync([FromRoute(Name ="id")]int id)
        {
            var query =await _mediator.Send(new GetProductByIdQuery(id));
            if (query == null)
            {
                return NotFound();
            }
            return Ok(query);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOneProductAsync([FromBody]CreateProductCommand createProductCommand)
        {
            var command =await _mediator.Send(createProductCommand);
            return CreatedAtAction(nameof(GetProductByIdAsync), new { command }, command);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProductAsync(int id, [FromBody] UpdateProductCommand command)
        {
            if (id != command.Id) return BadRequest(new { message = "URL ID ile gövdedeki ID uyuşmuyor." });

            var success = await _mediator.Send(command);
            if (!success) return NotFound(new { message = "Güncellenecek ürün bulunamadı." });

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            var success = await _mediator.Send(new DeleteProductCommand(id));
            if (!success) return NotFound(new { message = "Silinecek ürün bulunamadı." });

            return NoContent();
        }
    }
}
