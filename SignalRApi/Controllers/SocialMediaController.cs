using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Title = createSocialMediaDto.Title,
                URL = createSocialMediaDto.URL,
                Icon = createSocialMediaDto.Icon

            });
            return Ok("Ürün Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(values);
            return Ok("Ürün Bilgisi Silindi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Title = updateSocialMediaDto.Title,
                URL = updateSocialMediaDto.URL,
                Icon = updateSocialMediaDto.Icon
            });
            return Ok("Ürün Bilgileri Güncelledi");
        }
    }
}