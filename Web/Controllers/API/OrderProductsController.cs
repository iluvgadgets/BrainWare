using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace Web.Controllers
{
    using Models;

    public class OrderProductsController : ApiController
    {
        private BrainWareEntities db = new BrainWareEntities();

        // GET: api/OrderProducts
        public IQueryable<OrderProduct> GetOrderProducts()
        {
            return db.OrderProducts;
        }

        // GET: api/OrderProducts/5
        [ResponseType(typeof(OrderProduct))]
        public IHttpActionResult GetOrderProduct(int id)
        {
            OrderProduct orderProduct = db.OrderProducts.Find(id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return Ok(orderProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}