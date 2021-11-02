using CourseCatalogApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogApi.Controllers
{
    public class CourseCatalogController : ControllerBase
    {
        [HttpGet("course-catalog")]
        public async Task<ActionResult<GetCourseCatalogResponse>> GetAllCourses()
        {
            var response = new GetCourseCatalogResponse
            {
                Data = new List<CourseCatalogResponseItem>
                {
                    new CourseCatalogResponseItem { Id = 1, Title="DevOps Essentials", Description="For Everyone!", NumberOfDays = 2},
                    new CourseCatalogResponseItem { Id = 2, Title="DevOps For Service Developers", Description="For Developers", NumberOfDays = 2},
                    new CourseCatalogResponseItem { Id = 3, Title="Developer Workshop", NumberOfDays = 1, Type=CourseType.Online}
                }
            };
            return Ok(response);
        }
    }
}
