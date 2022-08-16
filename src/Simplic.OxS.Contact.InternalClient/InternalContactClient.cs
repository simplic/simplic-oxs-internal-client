using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Contact.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Contact.InternalClient
{
    /// <summary>
    /// Internal client to interact with the contact api.
    /// </summary>
    public class InternalContactClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalContactClient"/> with dependency injection.
        /// </summary>
        public InternalContactClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a contact by id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        public async Task<ContactInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<ContactInternalModel?>("contact", "InternalContact", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal contact call InternalContactClient.GetById", ex);
                throw;
            }
        }
    }
}