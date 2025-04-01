namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class TollInternalModel
{
    public DateTime? TollRegistrationDate { get; set; }
    public int? AxleCount { get; set; }
    public Guid? EmissionClassId { get; set; }
    public double? PermissableTotalWeight { get; set; }
    public Guid? TollEmissionClassId { get; set; }
    public string? OrderNumber { get; set; }
}
