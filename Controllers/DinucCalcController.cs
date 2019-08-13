using Microsoft.AspNetCore.Mvc;
using DinucMVC.Models;
using DinucMVC.Helpers;
using DinucMVC.Calculation;

namespace DinucMVC.Controllers
{
    public class DinucCalcController : Controller
    {
        public IActionResult Dinuc()
        {
            // Get seq from input in Form Textarea and put it to lower case.
            Sequence sequence = new Sequence();
            sequence.Seq = Request.Form["inputSeq"].ToString();
            sequence.Seq = sequence.Seq.ToLower();

            //Seq test for a, c, g, t only.
            SeqTest seqTest = new SeqTest();
            ViewBag.TestReturn = seqTest.SeqNucTest(sequence.Seq);

            //Calculate dinuc frequencies in two frames
            DinucCalculation dinucCalculation = new DinucCalculation(new DinucTable(), sequence.Seq);
            var list = dinucCalculation.SubseqListFirstFrame();

            //DinucTable dinucTable = new DinucTable();
            //ViewBag.DiTable = dinucTable;

            return View();
        }
    }
}
