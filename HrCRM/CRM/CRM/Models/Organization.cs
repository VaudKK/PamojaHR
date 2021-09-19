using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Models
{
    [Table("org")]
    public record Organization: BaseModel
    {

        [Column("org_id")]
        public Guid OrganizationId { get; init; }

        [Column("org_name")]
        public string Name { get; set; }

        [Column("org_email")]
        public string Email { get; init; }

        [Column("org_address")]
        public string Address { get; init; }

        [Column("org_primary_contact")]
        public string PrimaryContact { get; init; }

        [Column("org_creator")]
        public Guid UserId { get; init; }

    }
}

