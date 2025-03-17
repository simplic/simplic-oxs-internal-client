using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Telematic.InternalClient.Model;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Telematic.InternalClient
{
    /// <summary>
    /// Internal client to communicate with the internal loading aid type api.
    /// </summary>
    public class InternalTelematicWorkflowClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalTelematicWorkflowClient"/> with dependency injection.
        /// </summary>
        public InternalTelematicWorkflowClient(IOptions<AuthSettings> settings,
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
        public async Task<TelematicWorkflow?> Get(Guid id)
        {
            try
            {
                return await Get<TelematicWorkflow?>("logistics", "InternalLoadingAidType", id.ToString());
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could make internal loading aid type call InternalLoadingAidTypeClient.GetById");
                throw;
            }
        }
    }
}
