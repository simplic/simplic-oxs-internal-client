namespace Simplic.OxS.ConstructionSite.InternalClient.Model
{
    /// <summary>
    /// Represents the model of a construction site type from the construction site api gotten from the internal 
    /// controller.
    /// </summary>
    public class ConstructionSiteTypeInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the construction site type.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the number of the construciton site type.
        /// </summary>
        public string? Number { get; set; }
    }
}
