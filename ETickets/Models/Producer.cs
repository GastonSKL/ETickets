using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
