using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            Clientes c1 = new Clientes(1, "Michael", "michael.ctt@emailegal.com", "98938-3979", new DateOnly(1999, 6, 2));
            Clientes c2 = new Clientes(1, "Jim", "jimail@emailegal.com", "99228-4536", new DateOnly(2002, 2, 13));
            Clientes c3 = new Clientes(1, "Pam", "myemail@emailegal.com", "98381-1513", new DateOnly(2003, 4, 3));
            Clientes c4 = new Clientes(1, "Dwight", "masterofemails@emailegal.com", "98974-2337", new DateOnly(1998, 3, 4));
            Clientes c5 = new Clientes(1, "Perry", "secretemail@emailegal.com", "98034-5245", new DateOnly(2000, 12, 10));

            List<Clientes> listaClientes = new List<Clientes>();

            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
