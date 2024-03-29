﻿using System.ComponentModel.DataAnnotations.Schema;
using Common.CustomFilters;
using Model.Auth;
using Model.Helper;


namespace Model.Domain
{
    public class ReviewsPerCouse : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }

        public decimal Vote { get; set; }
        public string Commnet { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public bool Deleted { get; set; }
    }
}
