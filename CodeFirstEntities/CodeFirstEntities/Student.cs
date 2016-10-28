using System.ComponentModel.DataAnnotations;

namespace CodeFirstEntities
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Student Name is Mandatory")]
        [StringLength(20, ErrorMessage = "Student name must be less than 20 characters.")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

    }
}
