using example_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace example_api.Controllers
{
    public class ExampleController : ApiController
    {
        public PersonDto Get()
        {
            return new PersonDto
            {
                FirstName = "J.",
                LastName = "Tower",
                Age = 18
            };
        }
    }
}