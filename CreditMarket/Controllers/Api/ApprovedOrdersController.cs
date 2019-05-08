using AutoMapper;
using CreditMarket.Dtos;
using CreditMarket.Models;
using System.Linq;
using System.Web.Http;

namespace CreditMarket.Controllers.Api
{
    public class ApprovedOrdersController : ApiController
    {
        private readonly UnionsDbContext _context;

        public ApprovedOrdersController()
        {
            _context = new UnionsDbContext();
        }

        //GET /api/approvedOrders
        public IHttpActionResult GetApprovedOrders()
        {
            var approvedOrdersDtos = _context.ApprovedOrders.ToList().Select(Mapper.Map<ApprovedOrder, ApprovedOrderDto>);

            return Ok(approvedOrdersDtos);
        }

        //GET /api/approvedOrders/1
        public IHttpActionResult GetApprovedOrders(int id)
        {
            var approvedOrder = _context.ApprovedOrders.SingleOrDefault(x => x.Id == id);

            if (approvedOrder == null)
                return NotFound();

            return Ok(Mapper.Map<ApprovedOrder, ApprovedOrderDto>(approvedOrder));
        }

    }
}
