using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditImportService.Configuration;
using AuditImportService.Services;
using AuditImportService.Services.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditImportService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        private readonly StatusService _statusService;

        public StatusController(StatusService statusService)
        {
            _statusService = statusService;
        }
        
        
        [HttpGet("CurrentStatus")]
        public object Get()
        {
            //return new CurrentStatus();
            return _statusService.GetCurrentStatus();
        }
    }
}
