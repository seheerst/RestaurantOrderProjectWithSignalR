using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.TableDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TableController : ControllerBase
	{
		private readonly ITableService _tableService;

		public TableController(ITableService tableService)
		{
			_tableService = tableService;
		}

		[HttpGet("MenuTableCount")]
		public IActionResult MenuTableCount()
		{
			return Ok(_tableService.TMenuTableCount());
		}

        [HttpGet]
        public IActionResult TableList()
        {
            var values = _tableService.TGetAllList();
            return Ok(values);
        }
        [HttpPost]

        public IActionResult CreateTable(CreateTableDto createTableDto)
        {
            Table table = new Table()
            {
                Name = createTableDto.Name,
                Status = false,
            };
             _tableService.TAdd(table);
            return Ok("Eklendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTable(int id)
        {
            var value = _tableService.TGetById(id);
            _tableService.TDelete(value);
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult UpdateTable(UpdateTableDto updateTableDto)
        {
            Table table = new Table()
            {
                TableID = updateTableDto.TableID,
                Name = updateTableDto.Name,
                Status = false,
                
            };
            _tableService.TUpdate(table);
            return Ok("Güncellendi");
        }

        [HttpGet("{id}")]

        public IActionResult GetTable(int id)
        {
            var value = _tableService.TGetById(id);
            return Ok(value);
        }
    }
}
