using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hiring_and_Selection_Process_Platform.Models
{
    public class Education
    {
        [Key]
        public int educationId { get; set; }
        public string? educationTitle { get; set; }
        public double? cgpa { get; set; }
        public DateTime passingYear { get; set; }
        public string? universityName { get; set; }
        public string? degree { get; set; } // (Bachelors / Masters / PhD)
        public string? major { get; set; } // (Computer Science / Business / etc.)

        [ForeignKey("Candidates")]
        public int candidateId { get; set; } // Foreign key to Candidates table
        public virtual Candidates? candidates { get; set; } // Navigation property to Candidates table



    }
}
