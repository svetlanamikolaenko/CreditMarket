using AutoMapper;
using CreditMarket.Dtos;
using CreditMarket.Models;
using System;
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

        //POST /api/approvedOrders
        [HttpPost]
        public IHttpActionResult CreateApprovedOrders(ApprovedOrderDto approvedOrderDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var approvedOrder = Mapper.Map<ApprovedOrderDto, ApprovedOrder>(approvedOrderDto);
            _context.ApprovedOrders.Add(approvedOrder);
            _context.SaveChanges();

            approvedOrderDto.Id = approvedOrder.Id;

            return Created(new Uri(Request.RequestUri + "/" + approvedOrder.Id), approvedOrderDto);
        }

        //PATCH /api/approvedOrders/1
        [HttpPatch]
        public IHttpActionResult UpdateApprovedOrder(int id, ApprovedOrderDto approvedOrderDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var approvedOrderInDb = _context.ApprovedOrders.SingleOrDefault(l => l.Id == id);

            if (approvedOrderInDb == null)
                return NotFound();

            Mapper.Map(approvedOrderDto, approvedOrderInDb);

            _context.SaveChanges();
            return Ok();
        }

        //DELETE /api/approvedOrders/1
        [HttpDelete]
        public IHttpActionResult DeleteApprovedOrder(int id)
        {
            var approvedOrderInDb = _context.ApprovedOrders.SingleOrDefault(l => l.Id == id);

            if (approvedOrderInDb == null)
                return NotFound();

            _context.ApprovedOrders.Remove(approvedOrderInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
