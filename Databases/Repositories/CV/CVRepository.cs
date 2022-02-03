using Databases.Models;
using Databases.Repositories.Repository;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Repositories
{
    public class CVRepository : Repository<CV>, ICVRepository
    {
        public CVRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        

        public async Task<BaseResponse> AddCVAsync(AddCVDTO addCVDTO, Personal_Information personal_Information, Databases.Models.Experience_Information experience_Information)
        {
            
            
            var newCVEntity = new CV
            {
                Name = addCVDTO.Name,
                Experience_Information= experience_Information,
                Personal_Information= personal_Information
            };
            var CVEntity =  await AddAsync(newCVEntity);
          
            if (CVEntity != null)
                return new BaseResponse { IsSuccess = true, Message = "1" };
            return new BaseResponse { IsSuccess = false, Message = "0" };
        }

        public async Task<BaseResponse> DeleteCVAsync(int id)
        {
            var result = await GetAll().FirstOrDefaultAsync(x => x.Id == id);
            var removedEntity = await DeleteAsync(result);

            if (removedEntity != null)
                return new BaseResponse { IsSuccess = true, Message = "1" };
            return new BaseResponse { IsSuccess = false, Message = "0" };

        }

        public async Task<List<CV>> GetAllCVsAsync()
        {
            return await GetAll().Include(x => x.Experience_Information).Include(x => x.Personal_Information).ToListAsync();
        }

        public Task<CV> GetCVByEmailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CV> GetCVByIdAsync(int id)
        {
            return await GetAll().Include(x => x.Experience_Information).Include(x => x.Personal_Information).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Models.Experience_Information> GetExperience_InfoOfCVAsync(int id)
        {
            var result= await GetAll().FirstOrDefaultAsync(x => x.Id == id);
            return result.Experience_Information;
        }

        public async Task<Personal_Information> GetPersonal_InfoOfCVAsync(int id)
        {
            var result = await GetAll().FirstOrDefaultAsync(x => x.Id == id);
            return result.Personal_Information;
        }

       

        public async Task<BaseResponse> UpdateCVAsync(int id, AddCVDTO addCVDTO)
        {
            var result = await GetCVByIdAsync(id);

            result.Name = addCVDTO.Name;
            result.Personal_Information.CityName = addCVDTO.Personal_Info.CityName;
            result.Personal_Information.FullName = addCVDTO.Personal_Info.FullName;
            result.Personal_Information.Email = addCVDTO.Personal_Info.Email;
            result.Personal_Information.MobileNumber = addCVDTO.Personal_Info.MobileNumber;
            result.Experience_Information.City = addCVDTO.Experience_Info.City;
            result.Experience_Information.CompanyField = addCVDTO.Experience_Info.CompanyField;
            result.Experience_Information.CompanyName = addCVDTO.Experience_Info.CompanyName;

            var updatedEntity= await UpdateAsync(result);

            if (updatedEntity!= null)
                return new BaseResponse { IsSuccess = true, Message = "1" };
            return new BaseResponse { IsSuccess = false, Message = "0" };
        }

        
    }
}
