using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Erp.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Erp.InternalClient
{
    /// <summary>
    /// Internal client to interact with the internal personal account api.
    /// </summary>
    public class InternalPersonalAccountClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalPersonalAccountClient"/> with dependency injection.
        /// </summary>
        public InternalPersonalAccountClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a personal account by id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        public async Task<PersonalAccountInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<PersonalAccountInternalModel?>("erp", "InternalPersonalAccount", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal personal account call InternalPersonalAccountClient.GetById", ex);
                throw;
            }
        }
    }
}