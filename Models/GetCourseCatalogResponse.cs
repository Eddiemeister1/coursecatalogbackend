using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogApi.Models
{
    public class GetCourseCatalogResponse
    {
        public IList<CourseCatalogResponseItem> Data { get; set; }
    }

    public enum CourseType { SelfPaced, InstructorLed=99, Online }
    public class CourseCatalogResponseItem
    {
        public int Id { get; set; }
        [Required][MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int NumberOfDays { get; set; }

        public CourseType Type { get; set; } = CourseType.InstructorLed;

    }
}
