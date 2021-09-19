using System.ComponentModel.DataAnnotations;

namespace CRM.Dto
{
    public class OrganizationDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PrimaryContact { get; set; }
    }
}