using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wallmar.Models;

namespace wallmar.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            //Instância Lista de departamentos
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "brinquedos" });
            list.Add(new Departament { Id = 2, Name = "alimentação" });
            list.Add(new Departament { Id = 3, Name = "vestuario" });

            return View(list);
        }
    }
}