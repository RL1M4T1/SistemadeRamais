using SistemadeRamais.Models;
using SistemadeRamais.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Controllers
{
    public class CadastroController : Controller           
    {

        private readonly IRamalRepositorio _ramalRepositorio;


        public CadastroController(IRamalRepositorio ramalRepositorio)
        {
            _ramalRepositorio = ramalRepositorio;
        }
        public IActionResult Index()
        {
         List<CadastroModel> listaramal  = _ramalRepositorio.Buscartodos();
            return View(listaramal);
        }
        public IActionResult Alterar(int id)
        {
           CadastroModel cadastro = _ramalRepositorio.ListarporId(id);
            return View(cadastro);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            CadastroModel cadastro = _ramalRepositorio.ListarporId(id);
            return View(cadastro);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Filtrar(string nome, string setor)
        {
                CadastroModel cadastro = _ramalRepositorio.Filtrar(nome, setor);
                return View(cadastro);
        }
            


        [HttpPost]
        public IActionResult Criar(CadastroModel cadastro)
        {
           
          
                _ramalRepositorio.Adicionar(cadastro);
            return Redirect("Index");
            

        }

        [HttpPost]
        public IActionResult Editar(CadastroModel cadastro)
        {
            _ramalRepositorio.Editar(cadastro);
            return Redirect("Index");
        }
                
        public IActionResult Deletar(int id)
        {
            _ramalRepositorio.Deletar(id);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Retorna a mensagem de erro para a tela
        /// </summary>
        /// <param name="pMensagem"></param>
        /// <returns></returns>
        public string MostrarMensagemTela(string pMensagem)
        {
            return pMensagem;
        }

        /// <summary>
        /// Mensagem para informação
        /// </summary>
        /// <param name="pMensagemInformativa"></param>
        public void MostrarMensagemInformativo(string pMensagemInformativa)
        {
            TempData["info"] = MostrarMensagemTela(pMensagemInformativa);
        }

    }
}
