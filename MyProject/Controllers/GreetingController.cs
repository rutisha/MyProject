using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method return string hello world
        /// </summary>
        /// <returns>string "Hello World1!"</returns>
        /// <example>
        /// POST: localhost:xx/api/Greeting => Hello World!!
        /// </example>
       
        public string Post()
        {
            return "Hello World!!";
        }
        /// <summary>
        /// This method returns string of the integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>string with input number</returns>
        /// <example>
        /// GET: localhost:xx/api/Greeting/3 => Greetings to 3 people!
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/6 => Greetings to 6 people!
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/0 => Greetings to 0 people!
        /// </example>
        public string Get(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
