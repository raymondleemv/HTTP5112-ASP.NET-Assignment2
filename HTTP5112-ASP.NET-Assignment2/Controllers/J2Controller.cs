using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_ASP.NET_Assignment2.Controllers
{
    // Source: https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
    [Route("api/[controller]/DiceGame")]
    public class J2Controller : Controller
    {
        /// <summary>
        /// Output a message indicating the number of ways of rolling a value of 10 given the number of sides that the 2 dices have
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>A message indicating number of ways of rolling a value of 10 given the number of sides that the 2 dices have</returns>
        /// <example>
        /// GET api/J2/DiceGame/6/8 -> There are 5 ways to get the sum 10.
        /// GET api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10.
        /// GET api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10.
        /// GET api/J2/DiceGame/5/5 -> There are 1 ways to get the sum 10.
        /// </example>
        [HttpGet("{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            // The maximum number of ways of rolling a value of 10 is achieved by a combination of (m, n) = (9, 9)
            // The value of m and n will be capped at 9
            // Input validation:
            if (m > 9)
            {
                m = 9;
            } else if (m < 1)
            {
                m = 1;
            }
            if (n > 9)
            {
                n = 9;
            }
            else if (n < 1)
            {
                n = 1;
            }
            // If numWays is negative, (m, n) will be a combination of value that cannot roll a value of 10, -> return 0
            int numWays = n - (10 - m) + 1;
            numWays = numWays > 0 ? numWays : 0;
            return "There are " + numWays + " ways to get the sum 10.";
        }
    }
}

