using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final_semestre_2018.Util;
using Senai.OO.ProjetoFinal.Models;
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
        bool usuarioLogado = false;

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            ComentarioModel comentario = new ComentarioModel (texto: form["coment"]);
            if (Validacao.ValidarTexto (form["coment"]) == true) {
                comentario.DataCriacao = DateTime.Now;
                //Pegar o Id do Usuário Logado
                comentario.Usuario = HttpContext.Session.GetString ("nomeUsuario");
                if (comentario.Usuario ==null)
                {
                    ViewBag.Mensagem = "Você precisa estar logado para fazer comentários";   
                    return RedirectToAction ("index", "Comentario");
                } 
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
                ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
                ListaComentario.Aprovar (id);
                ViewData["Comentarios"] = ListaComentario.Listar();
                return RedirectToAction ("mostrar");
        }
    
        [HttpGet]
        public ActionResult Rejeitar (int id) {
                ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
                ListaComentario.Reprovar (id);
                ViewData["Comentarios"] = ListaComentario.Listar();
                return RedirectToAction ("mostrar");
        }

        [HttpGet]
        public ActionResult mostrar () {
            if (HttpContext.Session.GetString ("TipoUsuario") == "usuario") {
                return RedirectToAction ("index", "Comentario");
            } else {
             ComentarioRepSerealizado listaComentarios = new ComentarioRepSerealizado();
                ViewData["Comentarios"] = listaComentarios.Listar();
                return View ();
            }
        }

        [HttpGet]
        public IActionResult index () {
            ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
            ViewData["Comentarios"] = ListaComentario.ComentariosAprovados ();
            return View ();
        }
       

        [HttpGet]
        public IActionResult sobre () {
            ComentarioRepSerealizado ListaComentario = new ComentarioRepSerealizado ();
            ViewData["Comentarios"] = ListaComentario.ComentariosAprovados ();
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