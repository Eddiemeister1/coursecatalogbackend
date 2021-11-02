using CourseCatalogApi.Models;
using CourseCatalogApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogApi.Controllers
{
    public class CourseCatalogController : ControllerBase
    {
        //this is fake - not good for production.

        private readonly ICourseDataService _dataService;



        public CourseCatalogController(ICourseDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet("course-catalog")]
        [ResponseCache(Duration = 15)]
        public async Task<ActionResult<GetCourseCatalogResponse>> GetAllCourses()
        {
            await Task.Delay(2000); // Simulated - don't really do this.
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

        [HttpPut("course-catalog/{id:int}/numberOfDays/{days:int}")]
        public async Task<ActionResult> UpdateNumberOfDays(int id, int days)
        {
            await _dataService.UpdateNumberOfDays(id, days);
            return NoContent();// cool, Did it.
        }
    }
}
