using Microsoft.AspNetCore.Mvc;
using OnlineShop_Mvp.Services.Contracts;
using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos;

namespace OnlineShop.Controllers
{
    public class OrderDeatailController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDeatailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            return View(_orderDetailService.FillGrid());
        }
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderDetail_Save_Dto orderDetail)
        {
            if (ModelState.IsValid)
            {
                _orderDetailService.Save(orderDetail);
                RedirectToAction("Index");
            }
            return View(orderDetail);
        }

        public IActionResult Edit(Guid productID, Guid orderHeaderID)
        {
            var orderDetail = _orderDetailService.FindEdit(productID, orderHeaderID);
            return View(orderDetail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderDetail_Edit_Dto orderDetail)
        {
            if (ModelState.IsValid)
            {
                _orderDetailService.Edit(orderDetail);
                RedirectToAction("index");
            }
            return View(orderDetail);
        }
        public IActionResult Delete(Guid productID , Guid orderHeaderID)
        {
            _orderDetailService.Delete(productID , orderHeaderID);
            return RedirectToAction("index");
        }
        public IActionResult Details(Guid productID, Guid orderHeaderID)
        {
            var orderDetail = _orderDetailService.Find(productID, orderHeaderID);
            return View(orderDetail);
        }
    }
}
