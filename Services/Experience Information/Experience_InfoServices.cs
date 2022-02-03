using Databases.Models;
using Databases.Repositories;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class Experience_InfoServices : IExperience_InfoServices
    {
        private readonly IExperience_InfoRepository _Experience_InfoRepository;

        public Experience_InfoServices(IExperience_InfoRepository Experience_InfoRepository)
        {
            _Experience_InfoRepository = Experience_InfoRepository;
        }
        public Task<Experience_Information> Add(AddExperience_InfoDTO model)
        {
            return _Experience_InfoRepository.AddExperience_InfoAsync(model);
        }

        public Task<BaseResponse> Delete(int Id)
        {
            return _Experience_InfoRepository.DeleteExperience_InfoAsync(Id);
        }

        public Task<Experience_Information> Get(int Id)
        {
            return _Experience_InfoRepository.GetExperience_InfoByIdAsync(Id);
        }

        public Task<BaseResponse> Update(int Id, AddExperience_InfoDTO model)
        {
            return _Experience_InfoRepository.UpdateExperience_InfoAsync(model, Id);
        }
    }
}
