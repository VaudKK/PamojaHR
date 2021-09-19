using CRM.Dto;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    [ApiController]
    [Route("crm/setups")]
    public class OrganizationController
    {
        private readonly IOrganizationService organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            this.organizationService = organizationService;
        }

        [HttpPost]
        [Route("/create")]
        public async Task<ActionResult<object>> CreateOrganization(OrganizationDto organizationDto)
        {
            return await organizationService.CreateOrganization(organizationDto);
        }
    }
}