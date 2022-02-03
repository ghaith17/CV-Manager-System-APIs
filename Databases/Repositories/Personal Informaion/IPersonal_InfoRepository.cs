using Databases.Models;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Repositories
{
    public interface IPersonal_InfoRepository
    {
        Task<Personal_Information> AddPersonal_InfoAsync(AddPersonal_InfoDTO addPersonal_InfoDTO);

        Task<BaseResponse> UpdatePersonal_InfoAsync(AddPersonal_InfoDTO addPersonal_InfoDTO, int id);

        Task<BaseResponse> DeletePersonal_InfoAsync(int id);

        Task<Personal_Information> GetPersonal_InfoByIdAsync(int id);

        Task<List<Personal_Information>> GetAllPersonal_InfoAsync();
    }
}
