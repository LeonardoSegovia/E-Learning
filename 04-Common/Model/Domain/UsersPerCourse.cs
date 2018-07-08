using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Common.CustomFilters;
using Model.Auth;
using Model.Helper;


namespace Model.Domain
{
    public class UsersPerCouse : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
         
        [DefaultValue(false)]
        public bool Completed { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public bool Deleted { get; set; }
    }
}
