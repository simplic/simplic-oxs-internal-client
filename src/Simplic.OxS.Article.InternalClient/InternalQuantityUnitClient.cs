using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Article.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Article.InternalClient
{
    /// <summary>
    /// Internal client to communicate with the internal quantity unit api.
    /// </summary>
    public class InternalQuantityUnitClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalQuantityUnitClient"/> with dependency injection.
        /// </summary>
        public InternalQuantityUnitClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets an quanitity unit by id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        public async Task<QuantityUnitInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<QuantityUnitInternalModel?>("article", "InternalQuantityUnit", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal quantity unit call InternalQuantityUnitClient.GetById", ex);
                throw;
            }
        }
    }
}
