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

    public uint? PermissableTotalWeight { get; set; }

    public uint? PermissableTotalWeightInRegistrationState { get; set; }

    public uint? EmptyWeight { get; set; }

    public DateTime? RegistrationValidityPeriod { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? VehicleClass { get; set; }

    public string? EGTypeApprovalNumber { get; set; }

    public byte? AxleAmount { get; set; }

    public uint? PermissableBrakedTrailerLoad { get; set; } //

    public ushort? PermissableUnbrakedTrailerLoad { get; set; } //

    public uint? Displacement { get; set; }

    public uint? RatedPower { get; set; }

    public uint? RatedRPM { get; set; }

    public string? FuelType { get; set; }

    public decimal? PowerToWeightRatio { get; set; }

    public string? VehicleColor { get; set; }

    public ushort? SeatsIncludingDriverSeat { get; set; }

    public ushort? StandingPlaces { get; set; }

    public ushort? TopSpeed { get; set; }

    public byte? StandingNoise { get; set; }

    public ushort? StandingNoiseRPM { get; set; }

    public byte? DrivingNoise { get; set; }

    public ushort? Emissions { get; set; }

    public string? EGTypeEmissionClass { get; set; }

    public string? ManufacturerShortName { get; set; }

    public ushort? ManufacturerCode { get; set; }

    public string? TypeCodeWithCheckDigit { get; set; }

    public byte? VehicleIdentificationCheckDigit { get; set; }

    public string? SuperStructureType { get; set; }

    public string? VehicleClassDesignation { get; set; }

    public DateTime? EGTypeApprovalDate { get; set; }

    public uint? PermissableMaximumLoadAxle1 { get; set; }

    public uint? PermissableMaximumLoadAxle2 { get; set; }

    public uint? PermissableMaximumLoadAxle3 { get; set; }

    public uint? PermissableMaximumLoadAxle1InRegistrationState { get; set; }

    public uint? PermissableMaximumLoadAxle2InRegistrationState { get; set; }

    public uint? PermissableMaximumLoadAxle3InRegistrationState { get; set; }

    public byte? DriveAxleAmount { get; set; }

    public string? FuelTypeCode { get; set; }

    public string? ColorCode { get; set; }

    public uint? TankerTankCapacity { get; set; }

    public uint? TrailerNoseWeight { get; set; }

    public string? NationalEmissionClass { get; set; }

    public string? EmissionClassCode { get; set; }

    public string? TiresAxle1 { get; set; }

    public string? TiresAxle2 { get; set; }

    public string? TiresAxle3 { get; set; }

    public string? RegistrationCertificateNumberPart2 { get; set; }

    public string? OperatingPermitFeature { get; set; }

    public uint? Length { get; set; }

    public uint? Width { get; set; }

    public uint? Height { get; set; }

    public string? OtherNotes { get; set; }

    public string? RemarksAndExeptions { get; set; }

    public Guid? ZLBIIatId { get; set; }
}
