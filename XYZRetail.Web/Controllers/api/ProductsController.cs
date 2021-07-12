using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYZRetail.Core.Dtos;
using XYZRetail.Core.Entities;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Web.Controllers.Api
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var webRootPath = "";
            var products =  await _productService.GetProductsAsync(webRootPath);
            return  Ok(_mapper.Map<List<ProductDto>>(products));
        }
    }
}
