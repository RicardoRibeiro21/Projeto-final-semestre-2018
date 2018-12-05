using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final_semestre_2018.Repositorios;
using Projeto_final_semestre_2018.Util;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorio;

namespace Senai.OO.ProjetoFinal.Controllers {
    public class UsuarioController : Controller {
        private IUsuario UsuarioRepositorio { get; set; }
        //criando o método construtor

        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
         if (string.IsNullOrEmpty (form["nome"]) || string.IsNullOrEmpty (form["email"]) || string.IsNullOrEmpty (form["senha"]) || string.IsNullOrEmpty (form["senhaVerificacao"])) {
                UsuarioViewModel usuario = new UsuarioViewModel (nome: form["nome"],
                    email: form["email"],
                    senha: form["senha"]
                );
                //Verificando se o email inserido já existe
                // if (form["email"] != usuarioRepositorio.BuscarPorEmail (usuario.Email)) {
                //     //Validando o email e a confirmação de senha
                    if (Validacao.ValidarEmail (form["email"]) == true) {
                        //Validando o tipo de usuario
                        if (Validacao.ValidarUsuario (form["email"], form["senha"]) == true) {
                            usuario.Tipo = "administrador";
                        } else {
                            usuario.Tipo = "usuario";
                        }
                UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
                        usuarioRepositorio.Cadastrar (usuario);
                        ViewBag.Mensagem = "Usuário Cadastrado";
                    } else {
                        ViewBag.Mensagem = "Confirmação de senha inválida ou email incorreto";
                        return View ();
                    }
                // } else {
                //     ViewBag.Mensagem = "Email já cadastrado";
                //     return View ();
                // }
            } else {
                return View ();
            }
            return RedirectToAction ("FazerLogin", "Usuario");
        }

        [HttpGet]
        public IActionResult FazerLogin () {
            return View ();
        }

        [HttpPost]
        public IActionResult FazerLogin (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            UsuarioViewModel usuario = usuarioRepositorio.FazerLogin (form["email"], form["senha"]);
            if (usuario != null) {
                HttpContext.Session.SetString ("idUsuario", usuario.Id.ToString ());
                HttpContext.Session.SetString ("idUsuario", usuario.Nome.ToString ());
                if (usuario.Tipo == "administrador") {
                    return RedirectToAction ("aprovacao", "Comentario");
                }
                return RedirectToAction ("index", "Comentario");
            }
            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }
    }
}