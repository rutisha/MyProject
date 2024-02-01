using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// This method return final output of four mathematical operations
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>integer number after doing 4 mathematical operations on input number</returns>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/10 => 15
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Square/-5 => 0
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Addten/30 => 35
        /// </example>
        public int Get(int id)
        {
            int add = id + 10;
            int multiply = add * 2;
            int divide = multiply / 2;
            int output = divide - 5;

            return output;
        }
    }
}
