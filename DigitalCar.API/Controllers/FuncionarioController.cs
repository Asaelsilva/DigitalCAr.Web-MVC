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

        private FuncionarioAplicacao appFuncionario;
        public FuncionarioController()
        {
            appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioEF();
        }

        public ActionResult Funcionario()
        {
           // var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
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
                //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
                appFuncionario.Salvar(funcionario);
                return RedirectToAction("Funcionario");
            }

            return View(funcionario);
        }

        public ActionResult Editar(string id )
        {
            //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
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
                //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
                appFuncionario.Salvar(funcionario);
                return RedirectToAction("Funcionario");
            }

            return View(funcionario);
        }

        public ActionResult DetalharCadastro(string id)
        {
            //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
            var funcionario = appFuncionario.ListaPorId(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        public ActionResult Excluir(string id)
        {
            //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
            var funcionario = appFuncionario.ListaPorId(id);

            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(string id)
        {
            //var appFuncionario = FuncionarioAplicacaoConstrutor.FuncionarioApADO();
            var funcionario = appFuncionario.ListaPorId(id);
            appFuncionario.Excluir(funcionario);
            return RedirectToAction("Funcionario");
        }

    }
 
}