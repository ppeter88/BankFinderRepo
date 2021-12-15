using BankFinderAPI.Models;
using BankFinderAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Controllers
{
    [Route("api/bank")]
    [ApiController]
    public class BankController : ControllerBase
    {

        private readonly IBankServices _bankServices;
        public BankController(IBankServices bankServices)
        {
            _bankServices = bankServices;
        }

        [HttpPost("foradmin")]
        public ActionResult CreateBank([FromBody] InstitutionDto bankDto)
        {
            bool isBankCreated = _bankServices.Create(bankDto);
            if(!isBankCreated)
            {
                return BadRequest();
            }
            return Ok();
        }

        //[HttpGet]
        //public ActionResult<string> Test([FromQuery] string name)
        //{
        //    return $"Cześć {name}!!!";
        //}
    }
}
