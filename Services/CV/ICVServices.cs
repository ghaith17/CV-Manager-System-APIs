using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Databases.Models;
using Shared.DTOs;
using Shared.Responses;

namespace Services
{
    public interface ICVServices
    {
        Task<CV> Get(int Id);
        
        Task<List<CV>> GetAll();

        Task<BaseResponse> Add(AddCVDTO model);

        Task<BaseResponse> Update(int Id, AddCVDTO model);

        Task<BaseResponse> Delete(int Id);
    }
}
