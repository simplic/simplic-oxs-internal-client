namespace Simplic.OxS.Auth.InternalClient.Model
{
    internal class InternalOrganizationModel
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public Guid UserId { get; set; }
        public string UserEmailAddress { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
    }
}
