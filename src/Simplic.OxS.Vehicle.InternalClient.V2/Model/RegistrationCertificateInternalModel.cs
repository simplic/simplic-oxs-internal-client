namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class RegistrationCertificateInternalModel
{
    public string? Number { get; set; }
    public Guid? RegistratorId { get; set; }
    public string? Remarks { get; set; }
    public DateTime? FirstRegistrationDate { get; set; }
    public string? Manufacturer { get; set; }

    public string? Type { get; set; }

    public string? CommercialDesignation { get; set; }

    public string? VehicleIdentificationNumber { get; set; }

    public int? PermissableTotalWeight { get; set; }

    public int? PermissableTotalWeightInRegistrationState { get; set; }

    public int? EmptyWeight { get; set; }

    public DateTime? RegistrationValidityPeriod { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? VehicleClass { get; set; }

    public string? EGTypeApprovalNumber { get; set; }

    public byte? AxleAmount { get; set; }

    public int? PermissableBrakedTrailerLoad { get; set; } //

    public int? PermissableUnbrakedTrailerLoad { get; set; } //

    public int? Displacement { get; set; }

    public int? RatedPower { get; set; }

    public int? RatedRPM { get; set; }

    public string? FuelType { get; set; }

    public decimal? PowerToWeightRatio { get; set; }

    public string? VehicleColor { get; set; }

    public int? SeatsIncludingDriverSeat { get; set; }

    public int? StandingPlaces { get; set; }

    public int? TopSpeed { get; set; }

    public byte? StandingNoise { get; set; }

    public int? StandingNoiseRPM { get; set; }

    public byte? DrivingNoise { get; set; }

    public int? Emissions { get; set; }

    public string? EGTypeEmissionClass { get; set; }

    public string? ManufacturerShortName { get; set; }

    public int? ManufacturerCode { get; set; }

    public string? TypeCodeWithCheckDigit { get; set; }

    public byte? VehicleIdentificationCheckDigit { get; set; }

    public string? SuperStructureType { get; set; }

    public string? VehicleClassDesignation { get; set; }

    public DateTime? EGTypeApprovalDate { get; set; }

    public int? PermissableMaximumLoadAxle1 { get; set; }

    public int? PermissableMaximumLoadAxle2 { get; set; }

    public int? PermissableMaximumLoadAxle3 { get; set; }

    public int? PermissableMaximumLoadAxle1InRegistrationState { get; set; }

    public int? PermissableMaximumLoadAxle2InRegistrationState { get; set; }

    public int? PermissableMaximumLoadAxle3InRegistrationState { get; set; }

    public byte? DriveAxleAmount { get; set; }

    public string? FuelTypeCode { get; set; }

    public string? ColorCode { get; set; }

    public int? TankerTankCapacity { get; set; }

    public int? TrailerNoseWeight { get; set; }

    public string? NationalEmissionClass { get; set; }

    public string? EmissionClassCode { get; set; }

    public string? TiresAxle1 { get; set; }

    public string? TiresAxle2 { get; set; }

    public string? TiresAxle3 { get; set; }

    public string? RegistrationCertificateNumberPart2 { get; set; }

    public string? OperatingPermitFeature { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? OtherNotes { get; set; }

    public string? RemarksAndExeptions { get; set; }

    public Guid? ZLBIIatId { get; set; }
}
