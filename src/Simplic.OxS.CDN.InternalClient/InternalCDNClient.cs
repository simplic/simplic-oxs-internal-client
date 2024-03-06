using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.CDN.InternalClient;

/// <summary>
/// Internal client to interact with the CDN.
/// </summary>
public class InternalCDNClient : InternalClientBase
{
    private readonly ILogger logger;

    public InternalCDNClient(
        IOptions<AuthSettings> settings,
        IRequestContext requestContext,
        ILogger<InternalClientBase> logger,
        IConfiguration configuration
    )
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a file by it's blob id.
    /// </summary>
    /// <param name="blobId">Id of the file</param>
    /// <returns>Response containing the file stream and additional info</returns>
    public async Task<StreamResult?> GetFile(Guid blobId)
    {
        try
        {
            return await GetStream("cdn", "InternalCDN", $"get-file/{blobId}");
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed {ex}", ex);
            throw;
        }
    }

    /// <summary>
    /// Uploads bytes.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<UploadInternalResponse?> UploadBytes(UploadBytesInternalRequest request)
    {
        try
        {
            return await Post<UploadInternalResponse, UploadBytesInternalRequest>(
                "cdn",
                "InternalCDN",
                "upload",
                request
            );
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed {ex}", ex);
            throw;
        }
    }
}