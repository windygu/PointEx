using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PointEx.Entities;
using PointEx.Entities.Dto;
using PointEx.Security.Model;
using PointEx.Entities.Enums;
using System.Security.Principal;

namespace PointEx.Service
{
    public interface IShopService
    {
        Task Create(Shop shop, string shopEmail, string theme);
        void Edit(Shop shop);
        void Edit(Shop shop, string shopEmail);
        void Delete(int shopId);
        IQueryable<Shop> GetAll();
        List<ShopDto> GetAll(string sortBy, string sortDirection, string criteria, int? category, int? townId, bool? deleted, int pageIndex,
            int pageSize, out int pageTotal);
        Shop GetById(int id);
        Shop GetByUserId(string userId);
        void Dispose();
        List<ShopDto> GetShopByStatus(string sortBy, string sortDirection, int? categoryId, int? townId, StatusEnum status, string criteria,
            int pageIndex, int pageSize, out int pageTotal);
        void Moderated(int benefitId, int statusId);
    }
}