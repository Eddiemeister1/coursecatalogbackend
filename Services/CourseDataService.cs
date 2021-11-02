using CourseCatalogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CourseCatalogApi.Services
{
    public class CourseDataService : ICourseDataService
    {



        private List<CourseCatalogResponseItem> _courses;



        public CourseDataService()
        {
            _courses = new List<CourseCatalogResponseItem>
{
new CourseCatalogResponseItem { Id = 1, Title="DevOps Essentials", Description="For Everyone!", NumberOfDays = 2},
new CourseCatalogResponseItem { Id = 2, Title="DevOps For Service Developers", Description="For Developers", NumberOfDays = 2},
new CourseCatalogResponseItem { Id = 3, Title="Developer Workshop", NumberOfDays = 1, Type=CourseType.Online}
};
        }



        public async Task<IList<CourseCatalogResponseItem>> GetAll()
        {
            return _courses;
        }



        public async Task UpdateNumberOfDays(int id, int numberOfDays)
        {
            var course = _courses.Where(c => c.Id == id).Single();
            course.NumberOfDays = numberOfDays;
            var newCourses = _courses.Where(c => c.Id != id).ToList();
            newCourses.Add(course);
            _courses = newCourses;


        }
    }
}