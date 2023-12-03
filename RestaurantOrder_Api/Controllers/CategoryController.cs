using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.CategoryDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAllList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = createCategoryDto.Status,

            };
            _categoryService.TAdd(category);
            return Ok("eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryID = updateCategoryDto.CategoryID,
                CategoryName = updateCategoryDto.CategoryName,
                Status = updateCategoryDto.Status,

            };
            _categoryService.TUpdate(category);
            return Ok("güncellendi");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

    }
}
