using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["NomeAluno"] = "Thiago";
            ViewBag.NomeAluno = "Josefo";

            var pessoa = new Pessoa() { Nome = "Astolfo" };
            var homeViewModel = new HomeViewModel(pessoa);

            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Index([FromBody]Pessoa pessoa, [FromHeader]DadosX dadosX)
        {
            return View();
        }
        public ActionResult Edit(int nomeDoCliente)
        {
            return View();
        }
        public ActionResult Salvar(Pessoa pessoa)
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }

    internal class HomeViewModel
    {
        public Pessoa pessoa { get; set; }
        public HomeViewModel(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class DadosX
    {
        public string AppVersion { get; set; }
    }
}
