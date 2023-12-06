using System.ComponentModel.DataAnnotations;

namespace WebAPIpracticeOne.Models
{
    public class StudentDetails
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Class { get; set; }

    }
}
