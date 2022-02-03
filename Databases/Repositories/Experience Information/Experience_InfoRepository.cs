using Databases.Models;
using Databases.Repositories.Repository;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Repositories.Experience_Information
{
   public class Experience_InfoRepository : Repository<Models.Experience_Information>, IExperience_InfoRepository
    {
        public Experience_InfoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<Models.Experience_Information> AddExperience_InfoAsync(AddExperience_InfoDTO addExperience_InfoDTO)
        {


            var newExperience_InfoEntity = new Models.Experience_Information
            {
                City = addExperience_InfoDTO.City,
                CompanyField = addExperience_InfoDTO.CompanyField,
                CompanyName = addExperience_InfoDTO.CompanyName
            };
            var Experience_InfoEntity = await AddAsync(newExperience_InfoEntity);
            if (Experience_InfoEntity == null)
                return null;
            return Experience_InfoEntity;
        }

        public Task<BaseResponse> DeleteExperience_InfoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Models.Experience_Information>> GetAllExperience_InfoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Models.Experience_Information> GetExperience_InfoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpdateExperience_InfoAsync(AddExperience_InfoDTO addExperience_Info, int id)
        {
            throw new NotImplementedException();
        }
    }
}
