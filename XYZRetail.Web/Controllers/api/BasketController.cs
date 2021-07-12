using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYZRetail.Core.Dtos;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketController(IBasketService basketService,IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<BasketResponseDto>> AddBasket(BasketRequestDto basketDto)
        {
            var result = await _basketService.CreateBasket(basketDto);
            return Ok(_mapper.Map<BasketResponseDto>(result));
            //return RedirectToAction("View", "BasketMVC", new { basketResponseDto = response });
        }

        
    }
}
