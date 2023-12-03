﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.SocialMediaDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetAllList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            SocialMedia SocialMedia = new SocialMedia()
            {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url,
            };
            _socialMediaService.TAdd(SocialMedia);
            return Ok("eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            SocialMedia SocialMedia = new SocialMedia()
            {
                SocilMediaID = updateSocialMediaDto.SocilMediaID,
               Icon = updateSocialMediaDto.Icon,
               Title = updateSocialMediaDto.Title,
               Url = updateSocialMediaDto.Url
            };
            _socialMediaService.TUpdate(SocialMedia);
            return Ok("güncellendi");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
    }
}
