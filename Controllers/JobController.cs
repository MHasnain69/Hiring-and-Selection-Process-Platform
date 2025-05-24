using Hiring_and_Selection_Process_Platform.Data;
using Hiring_and_Selection_Process_Platform.Models;
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
        [Route("Job")]
        public IActionResult GetAllJobs()
        {
            var jobs = context.Jobs.ToList();
            return View(jobs);
        }

        // GET: /Job/CreateJob - Displays the form
        [HttpGet]
        [Route("Job/CreateJob")]
        public IActionResult CreateJob()
        {
            return View(); // Renders CreateJob.cshtml
        }

        [HttpPost]
        [Route("Job/CreateJob")]
        public IActionResult CreateJob(Job job)
        {
            if (ModelState.IsValid)
            {
                context.Jobs.Add(job);
                context.SaveChangesAsync();
                return RedirectToAction("Index"); // Redirect to the job list page

            }
            return View(job); // Return to the form with validation errors
        }

        [HttpPut]
        [Route("Job/UpdateJob/{id}")]
        public IActionResult UpdateJob(int id, [FromBody] Job job)
        {
            var _job = context.Jobs.Find(id);
            if (ModelState.IsValid)
            {
                context.Jobs.Update(job);
                context.SaveChanges();
                return Ok(new { message = "Job updated successfully" });

            }
            return View(job);
        }













    }
}
