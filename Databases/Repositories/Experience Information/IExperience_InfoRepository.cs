using Databases.Models;
using Databases.Repositories.Repository;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Repositories
{
    public interface IExperience_InfoRepository : IRepository<Models.Experience_Information>
    {
        Task<Models.Experience_Information> AddExperience_InfoAsync(AddExperience_InfoDTO addExperience_InfoDTO);

        Task<BaseResponse> UpdateExperience_InfoAsync(AddExperience_InfoDTO addExperience_Info, int id);

        Task<BaseResponse> DeleteExperience_InfoAsync(int id);

        Task<Models.Experience_Information> GetExperience_InfoByIdAsync(int id);

        Task<List<Models.Experience_Information>> GetAllExperience_InfoAsync(); 
    }
}
