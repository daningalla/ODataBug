using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ODataBug.Controllers
{
    [Route("api/[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public async Task<IQueryable<Tenant>> GetTenants()
        {
            var data = new Faker<Tenant>().Generate(50);            
    
            return data.AsQueryable();
        }
    }
}