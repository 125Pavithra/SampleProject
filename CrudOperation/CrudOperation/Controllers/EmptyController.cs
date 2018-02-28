using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudOperation.Controllers
{
    public class EmptyController : ApiController
    {//This is the sample application for source tree
        public string Post()
        {
            return "Creating Sub branch";
        }
    }
}
