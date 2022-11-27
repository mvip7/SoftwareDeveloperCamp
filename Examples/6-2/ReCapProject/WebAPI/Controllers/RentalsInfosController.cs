using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsInfosController : ControllerBase
    {
        IRentalsInfoService _rentalsInfoService;

        public RentalsInfosController(IRentalsInfoService rentalsInfoService)
        {
            _rentalsInfoService = rentalsInfoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalsInfoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(RentalsInfo rentalsInfo)
        {
            var result = _rentalsInfoService.Add(rentalsInfo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(RentalsInfo rentalsInfo)
        {
            var result = _rentalsInfoService.Update(rentalsInfo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
