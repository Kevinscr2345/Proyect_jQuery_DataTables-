using System.Diagnostics;
using Demo_Jquery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Jquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Crear una lista de empleados de ejemplo para la demostración
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Juan Pérez", Age = 30, Department = "Ventas" },
                new Employee { Id = 2, Name = "María García", Age = 25, Department = "Marketing" },
                new Employee { Id = 3, Name = "Carlos López", Age = 35, Department = "IT" },
                new Employee { Id = 4, Name = "Ana Rodríguez", Age = 28, Department = "Recursos Humanos" },
                new Employee { Id = 5, Name = "Pedro Martínez", Age = 40, Department = "Finanzas" },
                new Employee { Id = 6, Name = "Laura Sánchez", Age = 32, Department = "Ventas" },
                new Employee { Id = 7, Name = "Miguel Torres", Age = 29, Department = "Marketing" },
                new Employee { Id = 8, Name = "Sofia Ramírez", Age = 26, Department = "IT" },
                new Employee { Id = 9, Name = "Diego Fernández", Age = 31, Department = "Recursos Humanos" },
                new Employee { Id = 10, Name = "Lucía Gómez", Age = 27, Department = "Finanzas" },
                new Employee { Id = 11, Name = "Andrés Díaz", Age = 33, Department = "Ventas" },
            };

            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
