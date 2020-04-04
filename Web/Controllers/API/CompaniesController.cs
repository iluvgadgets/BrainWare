using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace Web.Controllers
{
    using Models;

    public class CompaniesController : ApiController
    {
        private BrainWareEntities db = new BrainWareEntities();

        // GET: api/Companies
        public IQueryable<Company> GetCompanies()
        {
            return db.Companies;
        }

        // GET: api/Companies/5
        [ResponseType(typeof(Company))]
        public IHttpActionResult GetCompany(int id)
        {

            Company company = db.Companies.Where(c => c.company_id == id).FirstOrDefault();
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
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