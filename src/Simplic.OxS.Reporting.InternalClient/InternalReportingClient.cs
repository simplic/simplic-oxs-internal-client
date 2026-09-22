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

        /// <summary>
        /// Renders a report
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RenderAndUploadReportResponse?> RenderAndUploadReport(RenderAndUploadReportRequest request)
        {
            try
            {
                return await Post<RenderAndUploadReportResponse, RenderAndUploadReportRequest>(
                    "reporting",
                    "InternalRendering",
                    "render-and-upload",
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

        /// <summary>
        /// Gets a report document by id.
        /// </summary>
        /// <param name="id">Report document id</param>
        /// <param name="omitBytes">If <c>true</c>, the report's bytes are omitted from the response.</param>
        /// <returns>The report document, or <c>null</c> if not found.</returns>
        public async Task<ReportDocumentModel?> GetReport(Guid id, bool omitBytes = false)
        {
            try
            {
                return await Get<ReportDocumentModel?>("reporting", "InternalReport", $"{id}",
                    new Dictionary<string, string>
                    {
                        { "omitBytes", $"{omitBytes}" }
                    });
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
