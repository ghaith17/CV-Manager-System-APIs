using Databases.Models;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IExperience_InfoServices
    {
        Task<Experience_Information> Get(int Id);

        Task<Experience_Information> Add(AddExperience_InfoDTO model);

        Task<BaseResponse> Update(int Id, AddExperience_InfoDTO model);

        Task<BaseResponse> Delete(int Id);
    }
}
