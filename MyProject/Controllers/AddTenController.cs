using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method return 10 more to the integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>input number added by 10</returns>
        /// <example>
        /// GET: localhost:xx/api/Addten/21 => 31
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Addten/0 => 10
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Addten/-9 => 1
        /// </example>
        public int Get(int id)
        {
            int total = id + 10;
            return total;
        }
    }
}
