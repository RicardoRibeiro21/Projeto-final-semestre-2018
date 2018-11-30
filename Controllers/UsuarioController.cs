using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorios;

namespace Senai.OO.ProjetoFinal.Controllers {
    public class UsuarioController : Controller {
        private IUsuario UsuarioRepositorioSerealizado { get; set; }
        //criando o método construtor
        public UsuarioController () {
            //Polimorfismo
            UsuarioRepositorioSerealizado = new UsuarioRepositorioSerealizado ();
        }

        [HttpGet]
        public IActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioViewModel usuario = new UsuarioViewModel (nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                tipo:  form["tipo"]
            );
            UsuarioRepositorioSerealizado.Cadastrar (usuario);
            
            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction ("Cadastrar", "Usuario");
        }
        [HttpGet]
        public IActionResult FazerLogin (){
            return View();
        }
        [HttpPost]
        public IActionResult FazerLogin (IFormCollection form) {

            UsuarioViewModel usuario = UsuarioRepositorioSerealizado.FazerLogin (form["email"], form["senha"]);
            if (usuario != null) {
                HttpContext.Session.SetString ("idUsuario", usuario.Id.ToString ());
                return RedirectToAction ("Cadastrar", "Usuario");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }
    }
}