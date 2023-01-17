using BIWEBAPI.DataContracts.Models;
using BIWEBAPI.DataContracts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIWEBAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkipOnController : ControllerBase
    {
        private readonly ISkipRepository _iskipRepository;
        public SkipOnController(ISkipRepository skipRepository)
        {
         this._iskipRepository=skipRepository;
        }


        [HttpGet("header")]
        public async Task<ActionResult> GetAllSkipOnDetails()
        {
            try
            {
                var data = await this._iskipRepository.GetAlldetails();
               
                return new CreatedResult(string.Empty, new { Code = 200, Status = true, StatusCode = "", Data = data });
            }
            catch (Exception ex)
            {
                return new CreatedResult(string.Empty, new { Code = 401, Status = false, Message = ex, Data = new { } });
            }
        }
        [HttpPost("AddSkipon")]
        public async Task<ActionResult> InsertSkiponDetails( SkipOn skipOn) 
        {
           await this._iskipRepository.AddNewCollectionData(skipOn);
            return Ok(new { ID = skipOn._id });
        }
    }
}
