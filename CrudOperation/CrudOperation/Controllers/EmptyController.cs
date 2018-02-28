using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudOperation.Controllers
{
    public class EmptyController : ApiController
    {
        public string Post()
        {
            return "Hello World";
        }
    }
}
