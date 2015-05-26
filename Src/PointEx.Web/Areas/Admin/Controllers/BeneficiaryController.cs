﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Framework.Common.Web.Alerts;
using Microsoft.AspNet.Identity;
using PagedList;
using PointEx.Entities.Dto;
using PointEx.Security.Managers;
using PointEx.Security.Model;
using PointEx.Service;
using PointEx.Web.Areas.Admin.Models;
using PointEx.Web.Controllers;
using PointEx.Web.Models;

namespace PointEx.Web.Areas.Admin.Controllers
{
    public class BeneficiaryController : BaseController
    {
        private readonly IBeneficiaryService _beneficiaryService;
        private readonly ApplicationUserManager _userManager;
        private readonly ICardService _cardService;

        public BeneficiaryController(IBeneficiaryService beneficiaryService, ApplicationUserManager userManager,ICardService cardService)
        {
            _beneficiaryService = beneficiaryService;
            _userManager = userManager;
            _cardService = cardService;
        }

        public ActionResult Index(BeneficiaryListFiltersModel filters)
        {
            int pageTotal;

            var beneficiarys = _beneficiaryService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.TownId, filters.EducationalInstitutionId, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<BeneficiaryDto>(beneficiarys, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new BeneficiaryListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(int id)
        {
            var beneficiary = _beneficiaryService.GetById(id);

            var beneficiaryForm = BeneficiaryForm.Create(beneficiary, new ApplicationUser());

            return View(beneficiaryForm);
        }

        public ActionResult Cards(int id)
        {
            var beneficiary= _beneficiaryService.GetById(id);
            var cards = _cardService.GetByBeneficiaryId(id);
            var beneficiaryCards = new BeneficiaryCardsModel(beneficiary, cards);

            return View(beneficiaryCards);
        }

        public ActionResult Create()
        {
            var beneficiaryForm = new BeneficiaryForm();
            return View(beneficiaryForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BeneficiaryForm beneficiaryForm)
        {
            if (!ModelState.IsValid)
            {
                return View(beneficiaryForm);
            }

            var beneficiary = beneficiaryForm.ToBeneficiary();

            var user = new ApplicationUser { UserName = beneficiaryForm.RegisterViewModel.Email, Email = beneficiaryForm.RegisterViewModel.Email };

            await _beneficiaryService.Create(beneficiary, user, beneficiaryForm.RegisterViewModel.Password);

            return RedirectToAction("Index", new BeneficiaryListFiltersModel().GetRouteValues()).WithSuccess("Beneficiario Creado");
        }

        public ActionResult Edit(int id)
        {
            var beneficiary = _beneficiaryService.GetById(id);
            var user = _userManager.FindById(beneficiary.UserId);
            var beneficiaryForm = BeneficiaryForm.Create(beneficiary, user);
            return View(beneficiaryForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BeneficiaryForm beneficiaryForm)
        {
            if (!ModelState.IsValid)
            {
                return View(beneficiaryForm);
            }

            _beneficiaryService.Edit(beneficiaryForm.ToBeneficiary());

            return RedirectToAction("Index", new BeneficiaryListFiltersModel().GetRouteValues()).WithSuccess("Beneficiario Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            _beneficiaryService.Delete(id);

            return RedirectToAction("Index", new BeneficiaryListFiltersModel().GetRouteValues()).WithSuccess("Beneficiario Eliminado");
        }
    }
}
