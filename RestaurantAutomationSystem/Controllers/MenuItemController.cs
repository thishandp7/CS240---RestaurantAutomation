
using RestaurantAutomationSystem.Models;
using RestaurantAutomationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantAutomationSystem.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenuItemController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult CreateItem()
        {
            var viewModel = new ItemInfoViewModel
            {
                Types = _context.TypeModel.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateItem(ItemInfoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.TypeModel.ToList();
                return View("CreateItem", viewModel);
            }
            var typeModel = new TypeModel();
            var itemInfo = new ItemInfo() {
                Type = _context.TypeModel.FirstOrDefault(t => t.Id == viewModel.Type),
                TypeId = viewModel.Type,
                Price = viewModel.dPrice
            };

            _context.ItemInfoTable.Add(itemInfo);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}