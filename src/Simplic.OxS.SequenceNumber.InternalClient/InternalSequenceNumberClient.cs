using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.SequenceNumber.InternalClient.Model;
using Simplic.OxS.Settings; 

namespace Simplic.OxS.SequenceNumber.InternalClient
{
    public class InternalSequenceNumberClient : InternalClientBase
    {
        private readonly ILogger logger;

        public InternalSequenceNumberClient(
                IOptions<AuthSettings> settings,
                IRequestContext requestContext,
                ILogger<InternalClientBase> logger,
                IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Creates a sequence number
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SequenceNumberResultInternalModel?> CreateSequenceNumber(GenerateSequenceNumberInternalRequest request)
        {
            try
            {
                return await Post<SequenceNumberResultInternalModel, GenerateSequenceNumberInternalRequest>(
                    "sequencenumber",
                    "InternalSequenceNumber",
                    "",
                    request);
            }
            catch (Exception ex)
            {
                logger.LogError("Internal call failed {ex}", ex);
                throw;
            }
        }
    }
}
