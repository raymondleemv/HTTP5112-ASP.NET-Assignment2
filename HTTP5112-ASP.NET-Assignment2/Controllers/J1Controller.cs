using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_ASP.NET_Assignment2.Controllers
{
    // Source: https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
    [Route("api/[controller]/menu")]
    public class J1Controller : Controller
    {
        /// <summary>
        /// Add the calories of the food chosen
        /// </summary>
        /// <param name="burgerChoice"></param>
        /// <param name="drinkChoice"></param>
        /// <param name="sideChoice"></param>
        /// <param name="dessertChoice"></param>
        /// <returns>The total calories of the food chosen</returns>
        /// <example>
        /// GET api/J1/4/4/4/4 -> 0
        /// GET api/J1/1/2/3/4 -> 691
        /// </example>
        [HttpGet("{burgerChoice}/{drinkChoice}/{sideChoice}/{dessertChoice}")]
        public int GetCalories(int burgerChoice, int drinkChoice, int sideChoice, int dessertChoice)
        {
            int[] burgerCaloriesArr = new int[4] { 461, 431, 420, 0 };
            int[] drinkCaloriesArr = new int[4] { 130, 160, 118, 0 };
            int[] sideCaloriesArr = new int[4] { 100, 57, 70, 0 };
            int[] dessertCaloriesArr = new int[4] { 167, 266, 75, 0 };
            // Input validation: if choice is invalid, choose none by default
            int burgerCalories = (burgerChoice > 4 || burgerChoice < 0) ? burgerCaloriesArr[3] : burgerCaloriesArr[burgerChoice - 1];
            int drinkCalories = (drinkChoice > 4 || drinkChoice < 0) ? drinkCaloriesArr[3] : drinkCaloriesArr[drinkChoice - 1];
            int sideCalories = (sideChoice > 4 || sideChoice < 0) ? sideCaloriesArr[3] : sideCaloriesArr[sideChoice - 1];
            int dessertCalories = (dessertChoice > 4 || dessertChoice < 0) ? dessertCaloriesArr[3] : dessertCaloriesArr[dessertChoice - 1];
            return burgerCalories + drinkCalories + sideCalories + dessertCalories;
        }
    }
}

