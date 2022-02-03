using Databases.Models;
using Databases.Repositories;
using Services;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CVServices : ICVServices
    {
        private readonly ICVRepository _CVRepository;
        private readonly IExperience_InfoServices _Experience_InfoServices;
        private readonly IPersonal_InfoServices _Personal_InfoServices;

        public CVServices(ICVRepository CVRepository, IExperience_InfoServices Experience_InfoServices, IPersonal_InfoServices Personal_InfoServices)
        {
            _CVRepository = CVRepository;
            _Experience_InfoServices = Experience_InfoServices;
            _Personal_InfoServices = Personal_InfoServices;
        }

        public async Task<BaseResponse> Add(AddCVDTO model)
        {
            var Experience_Info= await _Experience_InfoServices.Add(model.Experience_Info);
            var Personal_Info = await _Personal_InfoServices.Add(model.Personal_Info);

            return await _CVRepository.AddCVAsync(model, Personal_Info , Experience_Info);
        }

        public async Task<BaseResponse> Delete(int Id)
        {
            return await _CVRepository.DeleteCVAsync(Id);
        }

        public async Task<CV> Get(int Id)
        {
            return await _CVRepository.GetCVByIdAsync(Id);
        }
        public async Task<List<CV>> GetAll()
        {
            return await _CVRepository.GetAllCVsAsync();
        }

        public async Task<BaseResponse> Update(int Id, AddCVDTO model)
        {
            return await _CVRepository.UpdateCVAsync(Id,model);
        }
    }
}
