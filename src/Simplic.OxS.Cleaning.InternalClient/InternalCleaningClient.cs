using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Internal client to interact with the cleaning api.
    /// </summary>
    public class InternalCleaningClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalCleaningClient"/> with dependency injection.
        /// </summary>
        public InternalCleaningClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a cleaning by id.
        /// </summary>
        /// <param name="id">The cleaning id.</param>
        public async Task<InternalCleaningModel?> Get(Guid id)
        {
            try
            {
                return await Get<InternalCleaningModel?>("cleaning", "InternalCleaning", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not make internal cleaning call InternalCleaningClient.GetById");

                var iex = ex;
                while (iex.InnerException != null)
                {
                    logger.LogError(ex, "Could not make internal cleaning call InternalCleaningClient.GetById [InnerException]");
                    iex = iex.InnerException;
                }
                throw;
            }
        }
    }
}
