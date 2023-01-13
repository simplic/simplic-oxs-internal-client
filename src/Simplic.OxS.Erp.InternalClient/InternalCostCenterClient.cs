using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Erp.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Erp.InternalClient
{
    /// <summary>
    /// Internal client to interact with the internal cost center api.
    /// </summary>
    public class InternalCostCenterClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalCostCenterClient"/> with dependency injection.
        /// </summary>
        public InternalCostCenterClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a cost center by id.
        /// </summary>
        /// <param name="id">The cost center id.</param>
        public async Task<CostCenterInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<CostCenterInternalModel?>("erp", "InternalCostCenter", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal cost center call InternalCostCenterClient.GetById", ex);
                throw;
            }
        }
    }
}
