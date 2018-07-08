using System.ComponentModel.DataAnnotations.Schema;
using Model.Auth;


namespace Model.Domain
{
    public class LeassonsPerCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Video { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

    }
}
