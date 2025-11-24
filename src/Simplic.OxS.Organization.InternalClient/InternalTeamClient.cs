using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.Organization.InternalClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Organization.InternalClient
{
    public class InternalTeamClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalTeamClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<TeamInternalModel?> GetByGuid(Guid id)
        {
            try
            {
                return await Get<TeamInternalModel?>("organization", "InternalTeam", $"{id}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Could not make internal team call InternalTeamClient.Get/{id}", ex);
                return null;
                
            }
        }

        public async Task<IList<TeamInternalModel>?> GetAllByUserId(Guid id)
        {
            try
            {
                return await Get<IList<TeamInternalModel>?>("organization", "InternalTeam", "get-all-by-user", new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Could not make internal team call InternalTeamClient.GetAllByUserId", ex);
                throw;
            }
        }


    }
}
