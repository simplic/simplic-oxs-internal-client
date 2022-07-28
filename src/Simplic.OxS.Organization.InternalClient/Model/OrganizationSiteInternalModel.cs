using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Organization.InternalClient.Model
{
    public class OrganizationSiteInternalModel
    {
        public Guid Id { get; set; }


        public string Name { get; set; }

        public AddressInternalModel Address { get; set; } = new AddressInternalModel();
    }
}
