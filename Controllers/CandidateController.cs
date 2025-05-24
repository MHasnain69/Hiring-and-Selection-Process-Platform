using Hiring_and_Selection_Process_Platform.Data;
using Hiring_and_Selection_Process_Platform.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_and_Selection_Process_Platform.Controllers
{
    public class CandidateController : Controller
    {

        private readonly MyAppContext context;

        public CandidateController(MyAppContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCandidate()
        {
            return View();
        }

        [HttpPost]
        [Route("Candidate/CreateCandidate")]
        public IActionResult CreateCandidate(Candidates candidate)
        {
            if (ModelState.IsValid)
            {
                context.Candidates.Add(candidate);
                context.SaveChanges();
                return View();
            }
            return View(candidate);

        }






    }
}
