using BankDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankDBRestAPI.Controllers
{
    public class BankDBController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            
                using (BankAccountDBEntities entities = new BankAccountDBEntities())
                {
                    return entities.Customers.ToList();
                }
          
        }

        // GET api/<controller>/5
        public Customer Get(int id)
        {
            using (BankAccountDBEntities entities = new BankAccountDBEntities())
            {
                return entities.Customers.FirstOrDefault(c=>c.ID==id);
            }
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody] Customer value)
        {
            using (BankAccountDBEntities entities = new BankAccountDBEntities())
            {
                //implement using view model and frontend
                return Request.CreateResponse(HttpStatusCode.Created); 
            }
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody] string value)
        {
            using (BankAccountDBEntities entities = new BankAccountDBEntities())
            {
                //implement using view model and frontend
                return Request.CreateResponse(HttpStatusCode.OK); ;
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            using (BankAccountDBEntities entities = new BankAccountDBEntities())
            {
                //implement using view model and frontend
                return Request.CreateResponse(HttpStatusCode.OK); ;
            }
        }
    }
}