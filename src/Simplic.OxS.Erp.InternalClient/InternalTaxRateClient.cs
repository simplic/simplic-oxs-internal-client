using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Erp.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Erp.InternalClient
{
    /// <summary>
    /// Internal client to interact with the internal tax rate api.
    /// </summary>
    public class InternalTaxRateClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalTaxRateClient"/> with dependency injection.
        /// </summary>
        public InternalTaxRateClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a tax rate by id.
        /// </summary>
        /// <param name="id">The cost center id.</param>
        public async Task<TaxRateInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<TaxRateInternalModel?>("erp", "InternalTaxRateClient", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could not make internal tax rate call InternalTaxRateClient.GetById", ex);
                throw;
            }
        }
    }
}
