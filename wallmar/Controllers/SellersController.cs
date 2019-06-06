using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wallmar.Services;

namespace wallmar.Controllers
{
    public class SellersController : Controller
    {
        //ingeçao de dependencia
        private readonly SellerService _sellerService;

        //Construtor para finalizar a injeção de dependencia
        public SellersController(SellerService sellerService) {
            _sellerService = sellerService;
        }


        public IActionResult Index()
        {
            //Acessa o serviço e chama o metodo que retorna
            //a lista de sellers
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}