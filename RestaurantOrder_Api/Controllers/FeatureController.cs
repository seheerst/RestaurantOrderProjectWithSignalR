using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.FeatureDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _featureService.TGetAllList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            Feature Feature = new Feature()
            {
                FeatureName = createFeatureDto.FeatureName,
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,

            };
            _featureService.TAdd(Feature);
            return Ok("eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            Feature Feature = new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                FeatureName = updateFeatureDto.FeatureName,
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,

            };
            _featureService.TUpdate(Feature);
            return Ok("güncellendi");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
    }
}
