namespace Simplic.OxS.ConstructionSite.InternalClient.Model
{
    /// <summary>
    /// Model to represent a construction site from the construction site api for the internal client.
    /// </summary>
    public class ConstructionSiteInternalModel
    {
        /// <summary>
        /// Gets or sets the id of the construction site.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number for the construction site.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the name for the construction site.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the reference number.
        /// </summary>
        public string? ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets additional information.
        /// <para>
        /// Will contain information that might be needed for the construction site.
        /// </para>
        /// </summary>
        public string? AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the construction time.
        /// </summary>
        public string? ConstructionTime { get; set; }

        /// <summary>
        /// Gets or sets the type of a construction site.
        /// </summary>
        public ConstructionSiteTypeInternalModel? Type { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// <para>
        /// The address is the place where the construction site is located.
        /// </para>
        /// </summary>
        public AddressInternalModel? Address { get; set; }

        /// <summary>
        /// Gets or sets the contact person.
        /// <para>
        /// Represents the person in charge for the construciton site.
        /// </para>
        /// </summary>
        public AddressInternalModel? ContactPerson { get; set; }
    }
}
