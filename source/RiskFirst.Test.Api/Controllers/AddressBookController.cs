using Microsoft.AspNetCore.Mvc;
using System;

namespace RiskFirst.Test.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressBookController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
            => throw new NotImplementedException();
    }
}