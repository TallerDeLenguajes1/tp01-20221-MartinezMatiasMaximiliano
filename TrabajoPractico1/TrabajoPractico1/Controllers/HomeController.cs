using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico1.Models;

namespace TrabajoPractico1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Problema1(string _a)
        {
            try
            {
                int aux = Convert.ToInt32(_a);
                aux *= aux;
                return $"Numero ingresado:{_a} \nCuadrado de {_a}: {aux}";
            }
            catch (FormatException e)
            {
                return $"ಠ_ಠ) Dije: un numero... \n {e.Message}";
            }
        }

        public string Problema2(string _a,string _b)
        {
            try
            {
                int a = Convert.ToInt32(_a);
                int b = Convert.ToInt32(_b);
                float total = a / b;
                float resto = a % b;
                return $"{_a}/{_b}:{total:F2}\nResto:{resto}";
            }
            catch (DivideByZeroException e)
            {
                return $"No puede dividir en cero: {e.Message}";
            }
            catch (FormatException e) 
            {
                return $"Uno de los valores ingresados no es un numero! {e.Message}";
            }
        }

        public string Problema4(string _Km, string _L) 
        {
            try
            {
                int a = Convert.ToInt32(_Km);
                int b = Convert.ToInt32(_L);
                float total = a / b;
                return $"KM/L = {total:F2}";
            }
            catch (DivideByZeroException e)
            {
                return $"No puede dividir en cero: {e.Message}";
            }
            catch (FormatException e)
            {
                return $"Uno de los valores ingresados no es un numero! {e.Message}";
            }
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
