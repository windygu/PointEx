using System.Collections.Generic;
using System.Linq;
using PointEx.Entities;
using PointEx.Entities.Dto;

namespace PointEx.Service
{
    public interface IBenefitBranchOfficeService
    {
        BenefitBranchOffice GetById(int id);
                
        void Create(BenefitBranchOffice benefitBranchOffice);

        void Delete(int benefitBranchOfficeId);
    }
}