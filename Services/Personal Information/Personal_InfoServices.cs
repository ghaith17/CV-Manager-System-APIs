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
   public class Personal_InfoServices : IPersonal_InfoServices
    {
        private readonly IPersonal_InfoRepository _Experience_InfoRepository;

        public Personal_InfoServices(IPersonal_InfoRepository Personal_InfoRepository)
        {
            _Experience_InfoRepository = Personal_InfoRepository;
        }
        public Task<Personal_Information> Add(AddPersonal_InfoDTO model)
        {
            return _Experience_InfoRepository.AddPersonal_InfoAsync(model);
        }

        public Task<BaseResponse> Delete(int Id)
        {
            return _Experience_InfoRepository.DeletePersonal_InfoAsync(Id);
        }

        public Task<Personal_Information> Get(int Id)
        {
            return _Experience_InfoRepository.GetPersonal_InfoByIdAsync(Id);
        }

        public Task<BaseResponse> Update(int Id, AddPersonal_InfoDTO model)
        {
            return _Experience_InfoRepository.UpdatePersonal_InfoAsync(model, Id);
        }
    }
}
