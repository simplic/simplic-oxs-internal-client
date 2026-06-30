using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Reporting.InternalClient.Model;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Reporting.InternalClient
{
    public class InternalReportingClient : InternalClientBase
    {
        private readonly ILogger logger;

        public InternalReportingClient(
                IOptions<AuthSettings> settings,
                IRequestContext requestContext,
                ILogger<InternalClientBase> logger,
                IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Renders a report
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RenderReportInternalResponse?> RenderReport(RenderReportInternalRequest request)
        {
            try
            {
                return await Post<RenderReportInternalResponse, RenderReportInternalRequest>(
                    "reporting",
                    "InternalRendering",
                    "render",
                    request);
            }
            catch (InternalClientException ex)
            {
                logger.LogError("Internal call failed with status code {statusCode} and message {message}", ex.Result.StatusCode, ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError("Internal call failed {ex}", ex);
                throw;
            }
        }
    }
}
