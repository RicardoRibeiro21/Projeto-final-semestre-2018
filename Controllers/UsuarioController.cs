using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final_semestre_2018.Repositorios;
using Projeto_final_semestre_2018.Util;
using Senai.OO.ProjetoFinal.Interface;
using Senai.OO.ProjetoFinal.Models;

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
            if (!string.IsNullOrEmpty (form["nome"]) || !string.IsNullOrEmpty (form["email"]) || !string.IsNullOrEmpty (form["senha"]) || !string.IsNullOrEmpty (form["senhaVerificacao"])) {
                UsuarioViewModel usuario = new UsuarioViewModel (nome: form["nome"],
                    email: form["email"],
                    senha: form["senha"]
                );
                //     //Validando o email e a confirmação de senha
                if (!Validacao.ValidarEmail (form["email"]) && Validacao.BuscarPorEmail(form["email"]) == true) {
                    ViewBag.Mensagem = "Email inválido ou já cadastrado";
                    //Validando o tipo de usuario
                } else {
                    if (Validacao.ValidarUsuario (form["email"], form["senha"]) && Validacao.ValidarTexto (form["senha"]) == true) {
                        usuario.Tipo = "administrador";
                    } else {
                        usuario.Tipo = "usuario";
                    }
                    //Validando a senha
                    if (!Validacao.ValidarSenha (form["senha"], form["senhaVerificacao"])) {
                        ViewBag.Mensagem = "Confirmação de senha inválida.";
                        return View ();
                    } else {
                        //Cadastrando o usuário no  banco de dados
                        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
                        usuarioRepositorio.Cadastrar (usuario);
                        ViewBag.Mensagem = "Usuário Cadastrado";
                        return RedirectToAction ("FazerLogin", "Usuario");
                    }
                }
            } else {
                ViewBag.Mensagem = "Campos inválidos";
            }
            return RedirectToAction ("Cadastrar", "Usuario");
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
                HttpContext.Session.SetString ("nomeUsuario", usuario.Nome.ToString ());
                HttpContext.Session.SetString ("TipoUsuario", usuario.Tipo.ToString ());
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