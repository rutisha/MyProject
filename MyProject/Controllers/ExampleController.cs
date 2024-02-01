using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class ExampleController : ApiController
    {
        //receive request to localhost;xx/api/example
        // response will be "my first controllers!!"
        public int Get(int id)
        {
            return id;
        }
    }
}
