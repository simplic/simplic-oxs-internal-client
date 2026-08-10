using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.Document.InternalClient.V2.Model;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using System.ComponentModel.DataAnnotations;

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

    /// <summary>
    /// Creates a document.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<DocumentResponse?> Create(CreateDocumentInternalRequest request)
    {
        try
        {
            return await Post<DocumentResponse, CreateDocumentInternalRequest>(
                "document",
                "InternalDocument",
                "create",
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
    /// Adds a path to a document.
    /// </summary>
    /// <param name="documentId">Document id</param>
    /// <param name="request">Request containing the path to add</param>
    /// <returns></returns>
    public async Task<DocumentResponse?> AddPath(Guid documentId, AddDocumentPathRequest request)
    {
        try
        {
            return await Put<DocumentResponse, AddDocumentPathRequest>(
                "document",
                "InternalDocument",
                "add-path",
                request,
                new Dictionary<string, string>
                {
                    { "documentId", documentId.ToString() }
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

    /// <summary>
    /// Removes a path from a document.
    /// </summary>
    /// <param name="documentId">Document id</param>
    /// <param name="targetId">Target id of the path to remove</param>
    /// <returns></returns>
    public async Task<DocumentResponse?> RemovePath(Guid documentId, Guid targetId)
    {
        try
        {
            return await Delete<DocumentResponse>(
                "document",
                "InternalDocument",
                "remove-path",
                new Dictionary<string, string>
                {
                    { "documentId", documentId.ToString() },
                    { "targetId", targetId.ToString() }
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