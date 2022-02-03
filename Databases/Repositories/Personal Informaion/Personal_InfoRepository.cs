using Databases.Models;
using Databases.Repositories.Repository;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Repositories.Personal_Informaion
{
    public class Personal_InfoRepository : Repository<Personal_Information>, IPersonal_InfoRepository
    {
        public Personal_InfoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Personal_Information> AddPersonal_InfoAsync(AddPersonal_InfoDTO addPersonal_InfoDTO)
        {
            var newPersonal_InfoEntity = new Personal_Information
            {
                CityName = addPersonal_InfoDTO.CityName,
                FullName = addPersonal_InfoDTO.FullName,
                Email = addPersonal_InfoDTO.Email,
                MobileNumber = addPersonal_InfoDTO.MobileNumber
            };

            var Personal_InfoEntity = await AddAsync(newPersonal_InfoEntity);
            if (Personal_InfoEntity == null)
                return null;
            return Personal_InfoEntity;

        }

        public Task<BaseResponse> DeletePersonal_InfoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Personal_Information>> GetAllPersonal_InfoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Personal_Information> GetPersonal_InfoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpdatePersonal_InfoAsync(AddPersonal_InfoDTO addPersonal_InfoDTO, int id)
        {
            throw new NotImplementedException();
        }
    }
}
