using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public IActionResult Index()
        {
            List<Empresa> empresas = new List<Empresa>();

            empresas = _empresaRepository.ListarEmpresas();

            return View(empresas);
        }

        public IActionResult CadastroEmpresa()
        {
            Usuario usr = new Usuario
            {
                Nome = "Matheus Popp",
                Data_nasc = DateTime.Today,
                Genero = Enum.Genero.Masculino
            };

            Usuario usr2 = new Usuario
            {
                Nome = "Matheus Popp2",
                Data_nasc = DateTime.Today,
                Genero = Enum.Genero.Masculino
            };

            List<Usuario> list = new List<Usuario>();
            list.Add(usr);
            list.Add(usr2);


            ViewBag.list = list;

            return View();
        }

        [HttpPost]
        public IActionResult CadastrarEmpresa(Empresa empresa)
        {
            _empresaRepository.CadastrarEmpresa(empresa);

            return View();
        }
    }
}