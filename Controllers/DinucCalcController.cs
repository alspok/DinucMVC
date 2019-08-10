using Microsoft.AspNetCore.Mvc;
using DinucMVC.Models;
using DinucMVC.Helpers;

namespace DinucMVC.Controllers
{
    public class DinucCalcController : Controller
    {
        public ActionResult Dinuc()
        {
            // Get seq from input in Form Textarea and put it to lower case.
            Sequence.Seq = Request.Form["inputSeq"].ToString();
            Sequence.Seq = Sequence.Seq.ToLower();

            //Seq test for a, c, g, t only.
            SeqTest seqTest = new SeqTest();
            if (seqTest.SeqNucTest(Sequence.Seq) == false)
            {
                ViewData["nucTest"] = "Use a, c, g, t only.";
                return View();
            }

            //Seq partial output
            if (Sequence.Seq.Length > 32)
            {
                ViewData["seq"] = "1 " + Sequence.Seq.Substring(0, 16) + " ..... " + Sequence.Seq.Substring(Sequence.Seq.Length - 16) + " " + Sequence.Seq.Length;
            }
            else
            {
                ViewData["seq"] = "1 " + Sequence.Seq + " " + Sequence.Seq.Length;
            }

            return View();
        }


    }
}