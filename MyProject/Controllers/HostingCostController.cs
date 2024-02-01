using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method return 3 string of total hosting cost using input integer.
        /// </summary>
        /// <param name="id">The input number of the days which has elasped since starting of the hosting</param>
        /// <returns>The string which describe total hosting cost by calculating cost from input integer</returns>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/0 => “1 fortnights at $5.50/FN = $5.50 CAD | HST 13% = $0.72 CAD | Total = $6.22 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/14 => “2 fortnights at $5.50/FN = $11 CAD | HST 13% = $1.43 CAD | Total = $12.43 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/15 => “2 fortnights at $5.50/FN = $11 CAD | HST 13% = $1.43 CAD | Total = $12.43 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/21 => “2 fortnights at $5.50/FN = $11 CAD | HST 13% = $1.43 CAD | Total = $12.43 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/28 => “3 fortnights at $5.50/FN = $16.50 CAD | HST 13% = $2.18 CAD | Total = $18.64 CAD”
        /// </example>
        public string Get(int id)
        {
            int fortnight = id / 14;
            int calcharge = fortnight + 1;
            double amount = calcharge * 5.50;

            string charge = calcharge + " fortnights at $5.50/FN = $ " + amount + " CAD";

            double calHST = (amount * 13)/ 100;
            string HST = "HST 13% = $ " + calHST + " CAD";

            double total = amount + calHST;
            string finalmsg = "Total: $ " + total + " CAD";

            return charge + " | "  + HST + " | " + finalmsg;

        }
    }
}
