using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Article.InternalClient.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Article.InternalClient
{
    public class InternalArticleClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalArticleClient"/> with dependency injection.
        /// </summary>
        public InternalArticleClient(IOptions<AuthSettings> settings,
                                          IRequestContext requestContext,
                                          ILogger<InternalClientBase> logger,
                                          IConfiguration configuration)
            : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets an article by id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        public async Task<ArticleInternalModel?> Get(Guid id)
        {
            try
            {
                return await Get<ArticleInternalModel?>("article", "InternalArticle", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal article call InternalArticleClient.GetById", ex);
                throw;
            }
        }
    }
}
