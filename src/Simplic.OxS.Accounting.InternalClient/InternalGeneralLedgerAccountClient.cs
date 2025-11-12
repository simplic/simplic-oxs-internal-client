using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Accounting.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Auth.InternalClient
{
    public class InternalGeneralLedgerAccountClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalGeneralLedgerAccountClient(
                IOptions<AuthSettings> settings,
                IRequestContext requestContext,
                ILogger<InternalClientBase> logger,
                IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a vehicle by id.
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns></returns>
        public async Task<GeneralLedgerAccountInternalModel?> GetById(Guid id)
        {
            try
            {
                return await Get<GeneralLedgerAccountInternalModel?>("accounting", "InternalGeneralLedgerAccount", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", id.ToString() }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could not make internal accounting call InternalGeneralLedgerAccountClient.GetById", ex);
                throw;
            }
        }
    }
}