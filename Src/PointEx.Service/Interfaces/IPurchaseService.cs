using System.Collections.Generic;
using System.Linq;
using PointEx.Entities;
using PointEx.Entities.Dto;

namespace PointEx.Service
{
    public interface IPurchaseService
    {
        void Create(Purchase purchase);
        IList<PurchaseDto> GetTodayPurchasesByShopId(int shopId, int? branchOfficeId = null);
        IList<Purchase> GetAllByBeneficiaryId(int beneficiaryId);
        void Dispose();
    }
}