using Databases.Models;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPersonal_InfoServices
    {
        Task<Personal_Information> Get(int Id);

        Task<Personal_Information> Add(AddPersonal_InfoDTO model);

        Task<BaseResponse> Update(int Id, AddPersonal_InfoDTO model);

        Task<BaseResponse> Delete(int Id);
    }
}
