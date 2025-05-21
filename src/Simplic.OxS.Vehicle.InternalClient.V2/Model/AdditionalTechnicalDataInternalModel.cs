namespace Simplic.OxS.Vehicle.InternalClient.Model;

/// <summary>
/// Represents the model of additional technical data.
/// </summary>
public class AdditionalTechnicalDataInternalModel
{
    public decimal? EmptyWeight { get; set; }

    /// <summary>
    /// Gets or sets the totoal weigth of the vehicle in kg
    /// </summary>
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Gets or sets the total tire amount
    /// </summary>
    public int? TireAmount { get; set; }

    /// <summary>
    /// Gets or sets the steering tire size in mm
    /// </summary>
    public decimal? TireSizeSteeringAxle { get; set; }

    /// <summary>
    /// Gets or sets the lift axle tire size in mm
    /// </summary>
    public decimal? TireSizeLiftAxle { get; set; }

    /// <summary>
    /// Gets or sets the drive axle tire size in mm
    /// </summary>
    public decimal? TireSizeDriveAxle { get; set; }

    /// <summary>
    /// Gets or sets the payload (Nutzlast) of the vehicle in kg
    /// </summary>
    public decimal? Payload { get; set; }

    /// <summary>
    /// Gets or sets the amount of fuel currently filled in the vehicle in liter
    /// </summary>
    public decimal? FuelAmount { get; set; }

    /// <summary>
    /// Gets or sets the size of the rims on axle 1
    /// </summary>
    public string? RimSizeAxle1 { get; set; }

    /// <summary>
    /// Gets or sets the size of the rims on axle 2
    /// </summary>
    public string? RimSizeAxle2 { get; set; }

    /// <summary>
    /// Gets or sets the size of the rims on axle 3
    /// </summary>
    public string? RimSizeAxle3 { get; set; }

    /// <summary>
    /// Gets or sets the color of the vehicle frame
    /// </summary>
    public string? FrameColor { get; set; } = "";

    /// <summary>
    /// Gets or sets the execution of the vehicle
    /// </summary>
    public string? VehicleExecution { get; set; } = "";
    /// <summary>
    /// Gets or sets whether the vehicle has a fixed superstructure
    /// </summary>
    public bool? HasFixedSuperstructure { get; set; }

    /// <summary>
    /// Gets or sets the amount of parking spaces
    /// </summary>
    public int? SuperstructureParkingSpaces { get; set; }

    /// <summary>
    /// Gets or sets the volume inside the superstructure in cubic meters
    /// </summary>
    public decimal? SuperstructureVolume { get; set; }

    /// <summary>
    /// Gets or sets the inside length of the superstructure in meters
    /// </summary>
    public decimal? SuperstructureInsideLength { get; set; }

    /// <summary>
    /// Gets or sets the inside width of the superstructure in meters
    /// </summary>
    public decimal? SuperstructureInsideWidth { get; set; }

    /// <summary>
    /// Gets or sets the inside height of the superstructure in meters
    /// </summary>
    public decimal? SuperstructureInsideHeight { get; set; }

    /// <summary>
    /// Gets or sets the loading height in the back of the superstructure in meters
    /// </summary>
    public decimal? SuperstructureLoadingHeightBack { get; set; }

    /// <summary>
    /// Gets or sets the loading height in the back of the superstructure in meters
    /// </summary>
    public decimal? SuperstructureLoadingHeightFront { get; set; }

    /// <summary>
    /// Gets or sets the tire amound of the superstructure
    /// </summary>
    public int? SuperstructureTireAmount { get; set; }

    /// <summary>
    /// Gets or sets the size of the tires attached to the normal axis of the superstructure
    /// </summary>
    public decimal? SuperstructureTireSizeNormalAxis { get; set; }

    /// <summary>
    /// Gets or sets the size of the tires attached to the lift axle of the superstructure
    /// </summary>
    public decimal? SuperstructureTireSizeLiftAxle { get; set; }

}
