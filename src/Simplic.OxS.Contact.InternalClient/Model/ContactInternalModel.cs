using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Contact.InternalClient.Model
{
    public class ContactInternalModel
    {
        public AddressInternalModel Address { get; set; } = new AddressInternalModel();

        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Guid? UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
