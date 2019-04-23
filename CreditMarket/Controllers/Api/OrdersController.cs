using AutoMapper;
using CreditMarket.Dtos;
using CreditMarket.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace CreditMarket.Controllers.Api
{
    public class OrdersController : ApiController
    {
        private ApplicationDbContext _context;

        public OrdersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/orders
        public IHttpActionResult GetOrders()
        {
            var orderDtos = _context.Orders
                .Include(x => x.Loan)
                .ToList()
                .Select(Mapper.Map<Order, OrderDto>);

            return Ok(orderDtos);
        }

        //GET /api/orders/1
        public IHttpActionResult GetOrders(int id)
        {
            var order = _context.Orders.SingleOrDefault(l => l.Id == id);

            if (order == null)
                return NotFound();

            return Ok(Mapper.Map<Order, OrderDto>(order));
        }

        //POST /api/orders
        [HttpPost]
        public IHttpActionResult CreateOrder(OrderDto orderDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var order = Mapper.Map<OrderDto, Order>(orderDto);
            _context.Orders.Add(order);
            _context.SaveChanges();

            orderDto.Id = order.Id;

            return Created(new Uri(Request.RequestUri + "/" + order.Id), orderDto);
        }

        //PATCH /api/orders/1
        [HttpPatch]
        public IHttpActionResult UpdateOrder(int id, OrderDto orderDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var orderInDb = _context.Orders.SingleOrDefault(x => x.Id == id);

            if (orderInDb == null)
                return NotFound();

            Mapper.Map(orderDto, orderInDb);

            _context.SaveChanges();
            return Ok();
        }

        //DELETE /api/orders/1
        [HttpDelete]
        public IHttpActionResult DeleteOrder(int id)
        {
            var orderInDb = _context.Orders.SingleOrDefault(c => c.Id == id);

            if (orderInDb == null)
                return NotFound();

            _context.Orders.Remove(orderInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
