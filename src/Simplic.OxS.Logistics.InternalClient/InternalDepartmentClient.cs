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
    public class InternalDepartmentClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalDepartmentClient"/> with dependency injection.
        /// </summary>
        public InternalDepartmentClient(IOptions<AuthSettings> settings,
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
        public async Task<DepartmentResponse?> Get(Guid id)
        {
            try
            {
                return await Get<DepartmentResponse?>("logistics", "InternalDepartment", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could not make internal department type call InternalDepartmentClient.GetById", ex);
                throw;
            }
        }

        public override string ApiVersion { get => "v2"; set => base.ApiVersion = value; }
    }
}
