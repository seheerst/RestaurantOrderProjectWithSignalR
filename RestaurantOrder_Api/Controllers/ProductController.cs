using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.ProductDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetAllList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product Product = new Product()
            {
                ProductName = createProductDto.ProductName,
                Status = createProductDto.Status,
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
               

            };
            _productService.TAdd(Product);
            return Ok("eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product Product = new Product()
            {
                ProductID = updateProductDto.ProductID,
                ProductName = updateProductDto.ProductName,
                Status = updateProductDto.Status,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
            };
            _productService.TUpdate(Product);
            return Ok("güncellendi");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }
}
