using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method return square of the integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>input number is multiply by input number</returns>
        /// <example>
        /// GET: localhost:xx/api/Square/2 => 4
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Square/-2 => 4
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Addten/10 => 100
        /// </example>
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
