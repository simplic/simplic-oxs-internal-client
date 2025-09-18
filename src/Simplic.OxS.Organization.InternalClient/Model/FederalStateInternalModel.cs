
namespace Simplic.OxS.Organization.InternalClient.Model
{
    public class FederalStateInternalModel
    {
        /// <summary>
        /// Gets or sets the display name of the federal state
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the display key of the federal state
        /// </summary>
        public string DisplayKey { get; set; }
        /// <summary>
        /// Gets or sets the name of the federal state
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the ISO code of the federal state in ISO 3166-2 format (e.g., "DE-BE" for Berlin in Germany
        /// </summary>
        public string FederalStateIso { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the ISO 3166-2 code of the country the federal state belongs to (e.g., "DE" for Germany)
        /// </summary>
        public string CountryIso { get; set; } = string.Empty;
    }
}
