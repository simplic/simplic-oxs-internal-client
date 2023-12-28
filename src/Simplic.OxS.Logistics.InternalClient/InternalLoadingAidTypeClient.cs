using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Logistics.InternalClient.Model;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Logistics.InternalClient
{
    /// <summary>
    /// Internal client to communicate with the internal loading aid type api.
    /// </summary>
    public class InternalLoadingAidTypeClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalLoadingAidTypeClient"/> with dependency injection.
        /// </summary>
        public InternalLoadingAidTypeClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets an loading aid type by id.
        /// </summary>
        /// <param name="id">The loading aid type id.</param>
        public async Task<LoadingAidTypeInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<LoadingAidTypeInternalModel?>("logistics", "InternalLoadingAidType", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal loading aid type call InternalLoadingAidTypeClient.GetById", ex);
                throw;
            }
        }
    }
}
