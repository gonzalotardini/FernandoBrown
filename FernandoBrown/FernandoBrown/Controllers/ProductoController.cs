using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DAC;
namespace FernandoBrown.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public string ObtenerProductos(int pag = 0)
        {
            List<Producto> lista = new List<Producto>();
            Producto wow = new Producto()
            {
                nombre = "Destornillador filips re piola",
                categoria = "Destornillador",
                descripcion = "Destornillador filips de 20\" para la gente piola",
                precio = 29.99f,
                id = 1,
                imagen = "https://k60.kn3.net/taringa/0/2/3/4/5/8/cartucholombardi/F06.jpg" //CARTUCHO LOMBARDI JAJAJAJAJJ

            };
            for (int i = 0; i < 10; i++)
            {
                lista.Add(wow);
            }

            return JsonConvert.SerializeObject(lista.ToArray());
        }
    }
}