using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.AI.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.AI.InternalClient
{
    public class InternalConversationClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalConversationClient"/> with dependency injection.
        /// </summary>
        public InternalConversationClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Start an llm conversation
        /// </summary>
        /// <param name="id">The employee id.</param>
        public async Task<ConversationModel?> Start(StartConversationRequest model)
        {
            try
            {
                return await Post<ConversationModel, StartConversationRequest>("ai", "InternalConversation", "start", model);
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal ai call InternalConversation.StartConversation", ex);
                throw;
            }
        }
    }
}