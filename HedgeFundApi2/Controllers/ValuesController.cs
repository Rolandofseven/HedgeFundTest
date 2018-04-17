using HedgeFundApi2.Models;
using HedgeFundApi2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HedgeFundApi2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {
            var people = (new PeopleRepository()).GetPeople();

            return people.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] Person person)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
