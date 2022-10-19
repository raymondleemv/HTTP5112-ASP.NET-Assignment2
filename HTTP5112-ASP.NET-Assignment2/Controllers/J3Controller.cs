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
        public int CellPhoneMessaging(string word)
        {
            int time = 0;
            string[] keysArr = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            // Set initial prevGroup value to -1 so it wont match the first time the loop runs.
            int prevGroup = -1;
            // Loop through the input character by character to calculate the time needed
            for (int i = 0; i < word.Length; ++i)
            {
                // Loop through the keysArr to see which group the current character belongs to
                for (int j = 0; j < keysArr.Length; ++j)
                {
                    int index = keysArr[j].IndexOf(word[i]);
                    if (index != -1)
                    {
                        // Current letter is in the same group as the previous one, add pause time
                        if (j == prevGroup)
                        {
                            time += 2;
                        }
                        // The index of the character in keysArr equals to the number of key presses needed, add the time accordingly
                        time += index + 1;
                        // Set previous group
                        prevGroup = j;
                        break;
                    }
                }
            }
            return time;
        }
    }
}

