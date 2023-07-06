namespace WebApplication2.Models
{
    public class Todoo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }

        public TodooStatus Status { get; set; }//Top,Middle,High

        public apple Animal { get; set; }//apple,ball,cat
    }
            
    public  enum apple
    {
        apple,ball,cat
    }


}
