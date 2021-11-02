
using CourseCatalogApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace CourseCatalogApi.Services
{
    public interface ICourseDataService
    {
        Task<IList<CourseCatalogResponseItem>> GetAll();
        Task UpdateNumberOfDays(int id, int numberOfDays);
    }
}