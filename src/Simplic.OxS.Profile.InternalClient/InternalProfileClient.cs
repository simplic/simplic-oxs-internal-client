using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Profile.InternalClient.Model;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Profile.InternalClient
{
    public class InternalProfileClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalProfileClient"/> with dependency injection.
        /// </summary>
        public InternalProfileClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets the profile settings for the current user by making an internal API call to the "profile" endpoint.
        /// </summary>
        /// <returns>Profile</returns>
        public async Task<ProfileSettingsModel?> Get()
        {
            try
            {
                return await Get<ProfileSettingsModel?>("profile", "InternalProfile", "",
                    new Dictionary<string, string>
                    {

                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could not make internal profile call InternalProfileClient.Get", ex);
                throw;
            }
        }
    }
}