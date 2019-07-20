using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RomanController : Controller
    {

        // GET api/
        [HttpGet("{num}")]
        public ActionResult<string> Get(int num)
        {
            string complete = "";
            while (num > 0 && num < 5000)
            {
                if (num >= 1000)
                {
                    if (num / 1000 == 4)
                    {
                        complete += "MV";
                        num -= 4000;
                    }
                    else
                    {
                        complete += "M";
                        num -= 1000;
                    }

                }
                else if (num >= 100)
                {
                    if (num / 100 == 9)
                    {
                        complete += "CM";
                        num -= 900;
                    }
                    else if (num / 100 == 8)
                    {
                        complete += "DCCC";
                        num -= 800;
                    }
                    else if (num / 100 == 7)
                    {
                        complete += "DCC";
                        num -= 700;
                    }
                    else if (num / 100 == 6)
                    {
                        complete += "DC";
                        num -= 600;
                    }
                    else if (num / 100 == 5)
                    {
                        complete += "D";
                        num -= 500;
                    }
                    else if (num / 100 == 4)
                    {
                        complete += "CD";
                        num -= 400;
                    }
                    else if (num / 100 == 3)
                    {
                        complete += "CCC";
                        num -= 300;
                    }
                    else if (num / 100 == 2)
                    {
                        complete += "CC";
                        num -= 200;
                    }
                    else
                    {
                        complete += "C";
                        num -= 100;
                    }

                }
                else if (num >= 10)
                {
                    if (num / 10 == 9)
                    {
                        complete += "XC";
                        num -= 90;
                    }
                    else if (num / 10 == 8)
                    {
                        complete += "LXXX";
                        num -= 80;
                    }
                    else if (num / 10 == 7)
                    {
                        complete += "LXX";
                        num -= 70;
                    }
                    else if (num / 10 == 6)
                    {
                        complete += "LX";
                        num -= 60;
                    }
                    else if (num / 10 == 5)
                    {
                        complete += "L";
                        num -= 50;
                    }
                    else if (num / 10 == 4)
                    {
                        complete += "XL";
                        num -= 40;
                    }
                    else if (num / 10 == 3)
                    {
                        complete += "XXX";
                        num -= 30;
                    }
                    else if (num / 10 == 2)
                    {
                        complete += "XX";
                        num -= 20;
                    }
                    else
                    {
                        complete += "X";
                        num -= 10;
                    }

                }
                else
                {
                    if (num == 9)
                    {
                        complete += "IX";
                        num -= 9;
                    }
                    else if (num == 8)
                    {
                        complete += "VIII";
                        num -= 8;
                    }
                    else if (num == 7)
                    {
                        complete += "VII";
                        num -= 7;
                    }
                    else if (num == 6)
                    {
                        complete += "VI";
                        num -= 6;
                    }
                    else if (num == 5)
                    {
                        complete += "V";
                        num -= 5;
                    }
                    else if (num == 4)
                    {
                        complete += "IV";
                        num -= 4;
                    }
                    else if (num == 3)
                    {
                        complete += "III";
                        num -= 3;
                    }
                    else if (num == 2)
                    {
                        complete += "II";
                        num -= 2;
                    }
                    else if (num == 1)
                    {
                        complete += "I";
                        num -= 1;
                    }
                    else
                    {
                        complete += "0";
                    }
                }    

            }
            return complete;

        }
    }
}

