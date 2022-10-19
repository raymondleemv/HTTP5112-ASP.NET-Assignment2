using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_ASP.NET_Assignment2.Controllers
{
    [Route("api/[controller]/CellPhoneMessaging")]
    public class J3Controller : Controller
    {
        /// <summary>
        /// Calculates the time needed to type the input message on a cell phone.
        /// </summary>
        /// <param name="word">The input message</param>
        /// <returns>The number of seconds required to type the input message</returns>
        /// <example>
        /// GET api/J3/CellPhoneMessaging/a -> 1
        /// GET api/J3/CellPhoneMessaging/dada -> 4
        /// GET api/J3/CellPhoneMessaging/bob -> 7
        /// GET api/J3/CellPhoneMessaging/abba -> 12
        /// GET api/J3/CellPhoneMessaging/cell -> 13
        /// GET api/J3/CellPhoneMessaging/www -> 7
        /// </example>
        [HttpGet("{word}")]
        public int DiceGame(string word)
        {
            int time = 0;
            string[] keysArr = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            int prevGroup = -1;
            for (int i = 0; i < word.Length; ++i)
            {
                for (int j = 0; j < keysArr.Length; ++j)
                {
                    int index = keysArr[j].IndexOf(word[i]);
                    if (index != -1)
                    {
                        if (j == prevGroup)
                        {
                            time += 2;
                        }
                        time += index + 1;
                        prevGroup = j;
                        break;
                    }
                }
            }
            return time;
        }
    }
}

