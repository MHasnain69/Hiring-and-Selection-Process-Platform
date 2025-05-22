using Hiring_and_Selection_Process_Platform.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_and_Selection_Process_Platform.Controllers
{
    public class JobController : Controller
    {

        private readonly MyAppContext context;

        public JobController(MyAppContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("Job/GetAllJobs")]
        public IActionResult GetAllJobs()
        {
            var jobs = context.Jobs.ToList();
            return View(jobs);
        }













    }
}
