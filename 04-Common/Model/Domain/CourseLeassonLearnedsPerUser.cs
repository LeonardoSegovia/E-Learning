using System.ComponentModel.DataAnnotations.Schema;
using Common.CustomFilters;
using Model.Auth;
using Model.Helper;

namespace Model.Domain
{
    public class CourseLeassonLearnedsPerUser : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }

        public LeassonsPerCourse Leasson { get; set; }
        public int LeassonId { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }


        public bool Deleted { get; set; }
    }
}
