using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.Document.InternalClient.V2.Model;

namespace Simplic.OxS.Document.InternalClient.V2;

public class InternalDocumentClient : InternalClientBase
{
    private readonly ILogger logger;

    public InternalDocumentClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets the api version.
    /// </summary>
    public override string ApiVersion => "v2";

    /// <summary>
    /// Gets a document by id.
    /// </summary>
    /// <param name="id">Document id</param>
    /// <returns></returns>
    public async Task<DocumentResponse?> Get(Guid id)
    {
        try
        {
            return await Get<DocumentResponse?>("document", "InternalDocument", "",
                new Dictionary<string, string>
                {
                        { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets documents by paths. E.g. to get all documents for a shipment, contact, ...
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<IList<DocumentResponse>> GetByPath(GetDocumentsByPathsRequest request)
    {
        try
        {
            return await Post<IList<DocumentResponse>, GetDocumentsByPathsRequest>("document", "InternalDocument", "get-by-paths", request);
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed", ex);
            throw;
        }
    }
}