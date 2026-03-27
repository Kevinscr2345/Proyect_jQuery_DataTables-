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

            new Employee { Id = 1, Name = "Juan Pérez", Email = "Juan@gmail.com", Department = "Ventas", Cargo = "Analista", Salario = 1500, IsActive = true },
            new Employee { Id = 2, Name = "María García", Email = "maria@gmail.com", Department = "Marketing", Cargo = "Coordinadora", Salario = 1800, IsActive = true },
            new Employee { Id = 3, Name = "Carlos López", Email = "carlos@gmail.com", Department = "IT", Cargo = "Desarrollador", Salario = 1750, IsActive = true },
            new Employee { Id = 4, Name = "Ana Rodríguez", Email = "ana@gmail.com", Department = "Recursos Humanos", Cargo = "Reclutadora", Salario = 3600, IsActive = true },
            new Employee { Id = 5, Name = "Pedro Martínez", Email = "pedro@gmail.com", Department = "Finanzas", Cargo = "Contador", Salario = 4500, IsActive = false },
            new Employee { Id = 6, Name = "Laura Sánchez", Email = "laura@gmail.com", Department = "Ventas", Cargo = "Ejecutiva", Salario = 1500, IsActive = false },
            new Employee { Id = 7, Name = "Miguel Torres", Email = "miguel@gmail.com", Department = "Marketing", Cargo = "Diseñador", Salario = 1700, IsActive = true },
            new Employee { Id = 8, Name = "Sofía Ramírez", Email = "sofia@gmail.com", Department = "IT", Cargo = "Soporte", Salario = 1600, IsActive = true },
            new Employee { Id = 9, Name = "Diego Fernández", Email = "diego@gmail.com", Department = "Recursos Humanos", Cargo = "Analista", Salario = 1900, IsActive = true },
            new Employee { Id = 10, Name = "Lucía Gómez", Email = "lucia@gmail.com", Department = "Finanzas", Cargo = "Auditor", Salario = 2800, IsActive = true },
            new Employee { Id = 11, Name = "Andrés Díaz", Email = "andres@gmail.com", Department = "Ventas", Cargo = "Supervisor", Salario = 3000, IsActive = true },
            new Employee { Id = 12, Name = "Valeria Castro", Email = "valeria@gmail.com", Department = "Marketing", Cargo = "Community Manager", Salario = 2000, IsActive = false },
            new Employee { Id = 13, Name = "Jorge Morales", Email = "jorge@gmail.com", Department = "IT", Cargo = "Administrador de Sistemas", Salario = 3500, IsActive = true },
            new Employee { Id = 14, Name = "Camila Rojas", Email = "camila@gmail.com", Department = "Recursos Humanos", Cargo = "Asistente", Salario = 1400, IsActive = false },
            new Employee { Id = 15, Name = "Fernando Vargas", Email = "fernando@gmail.com", Department = "Finanzas", Cargo = "Tesorería", Salario = 3200, IsActive = true },
            new Employee { Id = 16, Name = "Daniela Herrera", Email = "daniela@gmail.com", Department = "Ventas", Cargo = "Vendedora", Salario = 1300, IsActive = false },
            new Employee { Id = 17, Name = "Ricardo Jiménez", Email = "ricardo@gmail.com", Department = "Marketing", Cargo = "Estratega", Salario = 2700, IsActive = false },
            new Employee { Id = 18, Name = "Paola Navarro", Email = "paola@gmail.com", Department = "IT", Cargo = "QA Tester", Salario = 2100, IsActive = true },
            new Employee { Id = 19, Name = "Gabriel Ortiz", Email = "gabriel@gmail.com", Department = "Recursos Humanos", Cargo = "Coordinador", Salario = 2900, IsActive = true },
            new Employee { Id = 20, Name = "Natalia Vega", Email = "natalia@gmail.com", Department = "Finanzas", Cargo = "Analista Financiero", Salario = 2600, IsActive = false },
            new Employee { Id = 21, Name = "Luis Castillo", Email = "luis@gmail.com", Department = "Ventas", Cargo = "Asesor Comercial", Salario = 2200, IsActive = true },
            new Employee { Id = 22, Name = "Andrea Solís", Email = "andrea@gmail.com", Department = "Marketing", Cargo = "Copywriter", Salario = 1950, IsActive = true },
            new Employee { Id = 23, Name = "Esteban Pineda", Email = "esteban@gmail.com", Department = "IT", Cargo = "DevOps", Salario = 4000, IsActive = false },
            new Employee { Id = 24, Name = "Karla Méndez", Email = "karla@gmail.com", Department = "Recursos Humanos", Cargo = "Generalista", Salario = 2300, IsActive = true },
            new Employee { Id = 25, Name = "Oscar Núñez", Email = "oscar@gmail.com", Department = "Finanzas", Cargo = "Controller", Salario = 4200, IsActive = false },

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
