using Microsoft.AspNetCore.Mvc;
using MeuPrimeiroProjetoMVC.Models;

namespace MeuPrimeiroProjetoMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Nome = "C#" });
            list.Add(new Department { Id = 1, Nome = "Java" });

            return View(list);
        }
    }
}
