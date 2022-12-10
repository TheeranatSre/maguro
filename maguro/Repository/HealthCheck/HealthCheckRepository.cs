using maguro.Data;

namespace maguro.Repository.HealthCheck
{
    public class HealthCheckRepository : IHealthCheckRepository
    {
        private readonly MaguroContext _context;

        public HealthCheckRepository(MaguroContext context)
        {
            this._context = context;
        }

        public string getetMessageHealthCheck()
        {
            var model = _context.HealthCheckModels.SingleOrDefault(e => e.id == 1);
            return model.message;
        }
    }
}
