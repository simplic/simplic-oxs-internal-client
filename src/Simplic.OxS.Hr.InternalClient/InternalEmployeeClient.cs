using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Hr.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Hr.InternalClient
{
    public class InternalEmployeeClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalEmployeeClient"/> with dependency injection.
        /// </summary>
        public InternalEmployeeClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets an employee by id.
        /// </summary>
        /// <param name="id">The employee id.</param>
        public async Task<EmployeeInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<EmployeeInternalModel?>("hr", "InternalEmployee", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal employee call InternalEmployeeClient.GetById", ex);
                throw;
            }
        }
    }
}