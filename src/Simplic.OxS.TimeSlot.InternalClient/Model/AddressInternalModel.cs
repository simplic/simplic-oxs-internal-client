namespace Simplic.OxS.TimeSlot.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of an address.
    /// </summary>
    public class AddressInternalModel
    {
        /// <summary>
        /// Gets or sets the first additional data.
        /// </summary>
        public string? Additional01 { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        public string? Zipcode { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the country iso.
        /// </summary>
        public string? CountryIso { get; set; }
    }
}
