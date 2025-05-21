namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class VehicleInternalModel
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    public string? Location { get; set; }
    public string? MatchCode { get; set; }
    public VehicleStatusInternalModel? Status { get; set; }
    public decimal? Mileage { get; set; }
    public DateTime? MileageDate { get; set; }
    public decimal? OperatingHours { get; set; }
    public int? FuelTankCapacity { get; set; }
    public string? Remark { get; set; }
    public string? DispositionSortingKey { get; set; }
    public DateTime? YearOfManufacturing { get; set; }
    public string? RegistrationDocument { get; set; }
    public string? VehicleRegistration { get; set; }
    public bool? IsSystemVehicle { get; set; }
    public DepartmentInternalModel? Department { get; set; }
    public VehicleEmissionClassInternalModel? EmissionClass { get; set; }
    public VehicleFinancialSupportStateInternalModel? FinancialSupportState { get; set; }
    public VehicleFuelTypeInternalModel? FuelType { get; set; }
    public VehicleInsuranceTypeInternalModel? InsuranceType { get; set; }
    public VehicleTrafficTypeInternalModel? TrafficType { get; set; }
    public VehicleTypeSubTypeInternalModel? VehicleTypeSubType { get; set; }
    public AdditionalTechnicalDataInternalModel? AdditionalTechnicalData { get; set; }
    public RegistrationCertificateInternalModel? RegistrationCertificate { get; set; }
    public RegistrationPlateInternalModel? RegistrationPlate { get; set; }
    public string? RegistrationDocumentLocation { get; set; }
    public TollInternalModel? Toll { get; set; }
    public DateTime? UsableUntil { get; set; }
    public IList<LoadingSlotInternalModel> LoadingSlots { get; set; } = new List<LoadingSlotInternalModel>();
    public IList<AppointmentInternalModel>? Appointments { get; set; } = new List<AppointmentInternalModel>();
}
