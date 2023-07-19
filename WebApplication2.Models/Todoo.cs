using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Todoo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]

        public TodooStatus Status { get; set; }//Top,Middle,High

        public apple Animal { get; set; }//apple,ball,cat

        public int  AuthorId { get; set; }

        public Author Author { get; set; }
    }
            
    public  enum apple
    {
        apple,ball,cat
    }


}
