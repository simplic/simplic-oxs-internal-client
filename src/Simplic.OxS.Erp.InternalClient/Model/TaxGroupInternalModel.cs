namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a tax group.
    /// </summary>
    public class TaxGroupInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the set of countries.
        /// </summary>
        public IList<CountryInternalModel> Countries { get; set; }
            = new List<CountryInternalModel>();

        /// <summary>
        /// Gets or sets the selectable flag.
        /// </summary>
        public bool IsSelectable { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets wether the tax group is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
