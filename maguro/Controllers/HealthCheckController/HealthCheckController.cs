using maguro.Models;
using maguro.Repository.HealthCheck;
using Microsoft.AspNetCore.Mvc;

namespace maguro.Controllers
{
    public class HealthCheckController : Controller
    {
        private readonly IHealthCheckRepository _healthCheckRepository;

        public HealthCheckController(IHealthCheckRepository healthCheckRepository)
        {
            _healthCheckRepository = healthCheckRepository;
        }

        [HttpGet("healthcheck")]
        public HealthCheckResponse HealthCheck()
        {
            HealthCheckResponse response = new HealthCheckResponse
            {
                status = _healthCheckRepository.getetMessageHealthCheck(),
                version = "version 0.0.1"
            };
            return response;
        }
    }
}
