using Microsoft.AspNetCore.Mvc;
using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos;
using OnlineShop_Mvp.Services.Contracts;
using OnlineShop.Services.Dtos.OrdersDtos.OrderHeaderDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop_Mvp.Controllers
{
    public class OrderHeaderController : Controller
    {
        private readonly IOrderHeaderService _orderHeaderService;

        public OrderHeaderController(IOrderHeaderService orderHeaderService)
        {
            _orderHeaderService = orderHeaderService;
        }

        public IActionResult Index()
        {
            return View(_orderHeaderService.FillGrid());
        }

        public IActionResult Create()
        {
            SelectList selectList = new SelectList(_orderHeaderService.PersonFillGrid());
            return View(selectList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderHeader_Save_Dto orderHeader)
        {
            if (ModelState.IsValid)
            {

                _orderHeaderService.Save(orderHeader);
                RedirectToAction("Index");
            }
            return View(orderHeader);
        }

        public IActionResult Edit(Guid id)
        {
            var product = _orderHeaderService.PersonFillGrid();
            var orderHeader = _orderHeaderService.FindEdit(id);
            return View(orderHeader);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderHeader_Edit_Dto orderHeader)
        {
            if (ModelState.IsValid)
            {
                _orderHeaderService.Edit(orderHeader);
                RedirectToAction("index");
            }
            return View(orderHeader);
        }
        public IActionResult Delete(Guid id)
        {
            _orderHeaderService.Delete(id);
            return RedirectToAction("index");
        }
        public IActionResult Details(Guid id)
        {
            var orderHeader = _orderHeaderService.Find(id);
            return View(orderHeader);
        }
    }
}
