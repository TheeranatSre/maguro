﻿using Microsoft.AspNetCore.Mvc;

namespace maguro.Controllers
{
    public class HealthCheckController : Controller
    {
        [HttpGet("healthcheck")]
       public string HealthCheck()
        {
            return "I'm fine, Thank you :)";
        }
    }
}
