namespace Simplic.OxS.Organization.InternalClient.Model
{
    /// <summary>
    /// Represents a billing address
    /// </summary>
    public class BillingAddressModel
    {
        /// <summary>
        /// Gets or sets the name of the billing recipient
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets some additional address information.
        /// </summary>
        public string Additional01 { get; set; }

        /// <summary>
        /// Gets or sets the street name
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the house number
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the zipcode
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country iso code (e.g. DE, FR, EN, US, ...)
        /// </summary>
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or sets the vat-id of the company
        /// </summary>
        public string VatId { get; set; }

        /// <summary>
        /// Gets or sets a list of mail-addresses for recieving invoices
        /// </summary>
        public IList<string> InvoiceRecipient { get; set; }
    }
}