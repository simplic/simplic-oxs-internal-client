using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Vehicle.InternalClient;

public class InternalVehicleTypeClient : InternalClientBase
{
    private readonly ILogger logger;

    public InternalVehicleTypeClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a vehicle type by id.
    /// </summary>
    /// <param name="id">Vehicle type id</param>
    /// <returns></returns>
    public async Task<VehicleTypeInternalModel?> Get(Guid id)
    {
        try
        {
            return await Get<VehicleTypeInternalModel?>("vehicleType", "InternalVehicleType", "",
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
    /// Gets a vehicle type by a alias.
    /// </summary>
    /// <param name="alias">A alias to find the vehicle type.</param>
    /// <returns></returns>
    public async Task<VehicleTypeInternalModel?> GetByAlias(string alias)
    {
        try
        {
            return await Get<VehicleTypeInternalModel?>("vehicleType", "InternalVehicleType", "get-by-alias",
                new Dictionary<string, string>
                {
                        { "alias", alias }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed", ex);
            throw;
        }
    }
}