using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.TimeSlot.InternalClient.Model;

namespace Simplic.OxS.TimeSlot.InternalClient
{
    /// <summary>
    /// Internal client to communicate with the internal site api.
    /// </summary>
    public class InternalSiteClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalSiteClient"/> with dependency injection.
        /// </summary>
        public InternalSiteClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a site by id.
        /// </summary>
        /// <param name="id">The site id.</param>
        public async Task<SiteInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<SiteInternalModel?>("timeslot", "InternalSite", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could make internal timeslot call InternalSiteClient.GetById");

                var iex = ex;
                while (iex.InnerException != null)
                {
                    logger.LogError(ex, "Could make internal timeslot call InternalSiteClient.GetById [InnerException]");
                    iex = iex.InnerException;
                }
                throw;
            }
        }
    }
}
