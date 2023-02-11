using Microsoft.AspNetCore.Mvc;
using System;

namespace Pilgrim_Assignment_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week5 : ControllerBase
    {
        [HttpPost(Name = "StdDevList")]
        public ActionResult<List<string>> IntListWork(List<int> lint)
        {
            List<string> slist = new List<string>();

            double mean = 0;
            double root = 0;
            double listTotal = 0;
            double sum = 0;
            double sumTotal = 0;
            double stdDev = 0;

            lint.Sort();

            foreach (int i in lint)
            {
                listTotal += i;
                mean = listTotal / lint.Count;
                sum = Math.Pow((i - mean), 2);
                sumTotal += sum;
                root = sumTotal/ lint.Count;
                stdDev = Math.Sqrt(root);

                if(i == 0) 
                {                   
                    slist.Add("Number " + i + " Added: Not enough information for standard deviation");
                } else
                {
                    slist.Add("Number " + i + " added: New Standard Deviation = " + String.Format("{0:0.00}", stdDev));
                }              
            }
            return Accepted(slist);
        }
    }
}