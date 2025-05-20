using System.ComponentModel.DataAnnotations;

namespace Hiring_and_Selection_Process_Platform.Models
{
    public class Jobs
    {
        [Key]
        private int jobId { get; set; }


        public string jobTitle { get; set; }
        public string jobDescription { get; set; }
        public string jobLocation { get; set; }
        public string jobType { get; set; }  // (part time / full time / intern)
        public string jobSalary { get; set; }
        public string jobCompanyName { get; set; }
        public string jobRequirements { get; set; }
        public DateTime deadline { get; set; }
        public int noEmployees { get; set; } // number of employees required for the job



    }
}
