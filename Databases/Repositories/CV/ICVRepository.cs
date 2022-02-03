using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Databases.Models;
using Databases.Repositories.Repository;
using Shared.DTOs;
using Shared.Responses;

namespace Databases.Repositories
{
    public interface ICVRepository : IRepository<CV>
    {
        Task<BaseResponse> AddCVAsync(AddCVDTO addCVDTO, Personal_Information personal_Information, Databases.Models.Experience_Information experience_Information);

        Task<BaseResponse> UpdateCVAsync(int id, AddCVDTO addCVDTO);

        Task<BaseResponse> DeleteCVAsync(int id);

        Task<CV> GetCVByIdAsync(int id);

        Task<CV> GetCVByEmailAsync(int id);

        Task<Personal_Information> GetPersonal_InfoOfCVAsync(int id);

        Task<Models.Experience_Information> GetExperience_InfoOfCVAsync(int id);

        Task<List<CV>> GetAllCVsAsync();
    }
}
