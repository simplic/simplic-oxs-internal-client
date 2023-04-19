namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class VehicleStatusInternalModel
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    public bool IsDeleted { get; set; }
    public string? Name { get; set; }
    public bool? IsSelectable { get; set; }
}
