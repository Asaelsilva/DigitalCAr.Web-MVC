using DigitalCar.Aplicacao;
using DigitalCar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalCar.API.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario

        public ActionResult Funcionario()
        {
            var appFuncionario = new FuncionarioAplicacao();
            var listaFuncionario = appFuncionario.Lista();

            return View(listaFuncionario);
        }

        public ActionResult CadastrarFuncionario()
        {


            return View();
        }

        [HttpPost]
        public ActionResult CadastrarFuncionario(Funcionario funcionario)
        {
            
            if (ModelState.IsValid)
            {
                var appFuncionario = new FuncionarioAplicacao();
                appFuncionario.Salvar(funcionario);
                return RedirectToAction("Funcionario");
            }

            return View(funcionario);
        }

        public ActionResult Editar(int id )
        {
            var appFuncionario = new FuncionarioAplicacao();
            var funcionario = appFuncionario.ListaPorId(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Editar(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var appFuncionario = new FuncionarioAplicacao();
                appFuncionario.Salvar(funcionario);
                return RedirectToAction("Funcionario");
            }

            return View(funcionario);
        }

        public ActionResult DetalharCadastro(int id)
        {
            var appFuncionario = new FuncionarioAplicacao();
            var funcionario = appFuncionario.ListaPorId(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        public ActionResult Excluir(int id)
        {
            var appFuncionario = new FuncionarioAplicacao();
            var funcionario = appFuncionario.ListaPorId(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(int id)
        {
            var appFuncionario = new FuncionarioAplicacao();
            appFuncionario.Excluir(id);
            return RedirectToAction("Funcionario");
        }

    }
 
}