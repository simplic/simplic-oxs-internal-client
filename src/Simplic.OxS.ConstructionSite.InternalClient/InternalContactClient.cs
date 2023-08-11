using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.ConstructionSite.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.ConstructionSite.InternalClient
{
    /// <summary>
    /// Internal client to interact with the contact api.
    /// </summary>
    public class InternalConstructionSiteClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalConstructionSiteClient"/> with dependency injection.
        /// </summary>
        public InternalConstructionSiteClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a construction site by id.
        /// </summary>
        /// <param name="id">The construction site id.</param>
        public async Task<ConstructionSiteInternalModel?> GetById(Guid id)
        {
            try
            {
                return await Get<ConstructionSiteInternalModel?>("Construction-Site", "InternalConstructionSite", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could make internal construction site call InternalConstructionSiteClient.GetById");

                var iex = ex;
                while (iex.InnerException != null)
                {
                    logger.LogError(ex, "Could make internal construction call InternalConstructionSiteClient.GetById [InnerException]");
                    iex = iex.InnerException;
                }
                throw;
            }
        }
    }
}
