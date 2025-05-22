using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Hiring_and_Selection_Process_Platform.Models
{
    public class Candidates
    {
        [Key]
        public int candidateId { get; set; }
        public string candidateName { get; set; }
        public string candidateEmail { get; set; }
        public string candidateContact { get; set; }
        public int candidateAge { get; set; }
    }
}
