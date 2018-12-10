using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final_semestre_2018.Util;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorio;
using Senai.OO.ProjetoFinal.Repositorios;

namespace Senai.OO.ProjetoFinal.Controllers {

    public class ComentarioController : Controller {
        [HttpGet]
        public ActionResult Cadastrar () {
            //Verificar se tem alguém logado
            if (string.IsNullOrEmpty (HttpContext.Session.GetString ("idUsuario"))) {
                return RedirectToAction ("Login", "Usuario");
            }
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            ComentarioModel comentario = new ComentarioModel (texto: form["coment"]);
            if (Validacao.ValidarTexto (form["coment"]) == true) {
                comentario.DataCriacao = DateTime.Now;
                //Pegar o Id do Usuário Logado
                comentario.Usuario = HttpContext.Session.GetString ("NomeUsuario");
                comentario.Aprovacao = false;
                ComentarioRepSerealizado comentarioRep = new ComentarioRepSerealizado ();
                comentarioRep.Cadastrar (comentario);
                ViewBag.Mensagem = "Comentário cadastrado, aguarde a aprovação dos administradores";
                Console.WriteLine (comentario.Texto);
            } else {
                ViewBag.Mensagem = "Mensagem inválida.";
            }
            return RedirectToAction ("index", "Comentario");
        }

        [HttpGet]
        public ActionResult Aprovacao (int id) {
            if (HttpContext.Session.GetString ("TipoUsuario") == "usuario") {
                return RedirectToAction ("index", "Comentario");
            } else {
                ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
                ViewData["Comentarios"] = ListaComentario.  Listar();
                Console.WriteLine(ListaComentario.Listar().Count);
                ListaComentario.Aprovar (id);
                return RedirectToAction ("mostrar");
            }
        }

        [HttpGet]
        public ActionResult mostrar () {
             ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
                ViewData["Comentarios"] = ListaComentario.Listar();
                return View ();
        }

        [HttpGet]
        public IActionResult index () {
            ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
            ViewData["ComentariosAprovados"] = ListaComentario.Listar ();
            return View ();
        }

        [HttpGet]
        public IActionResult sobre () {
            return View ();
        }

        [HttpGet]
        public IActionResult Contato () {
            return View ();
        }

        [HttpGet]
        public IActionResult perguntas () {
            return View ();
        }

        [HttpGet]
        public IActionResult Listar () {
            ComentarioRepSerealizado comentarios = new ComentarioRepSerealizado ();
            ViewData["Comentarios"] = comentarios.Listar ();
            return View ();
        }
    }
}