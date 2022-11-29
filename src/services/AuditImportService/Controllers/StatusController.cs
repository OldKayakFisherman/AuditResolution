using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditImportService.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditImportService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet("CurrentStatus")]
        public CurrentStatus Get()
        {
            return new CurrentStatus();
        }
    }
}
