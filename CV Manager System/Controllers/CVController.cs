using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Manager_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {
        private readonly ICVServices _CVService;

        public CVController(ICVServices CVService)
        {
            _CVService = CVService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCV()
        {
            var response = await _CVService.GetAll();
            if (response == null)
            {
                return BadRequest(new BaseResponse { IsSuccess = false, Message = "0" });
            }

            return Ok(response);

        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetCV([FromQuery] int id)
        {
            var response = await _CVService.Get(id);
            if (response == null)
            {
                return BadRequest(new BaseResponse { IsSuccess = false, Message = "0" });
            }

            return Ok(response);

        }
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] AddCVDTO dataModel)
        {
            
            var response = await _CVService.Add(dataModel);

            if (response.IsSuccess) return Ok(response);

            return BadRequest(response);
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromQuery] int id,[FromBody] AddCVDTO dataModel)
        {
            
            var response = await _CVService.Update(id,dataModel);

            if (response.IsSuccess) return Ok(response);

            return BadRequest(response);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {

            var response = await _CVService.Delete(id);

            if (response.IsSuccess) return Ok(response);

            return BadRequest(response);
        }
    }
}
