using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final_semestre_2018.Util;
using Senai.OO.ProjetoFinal.Models;
using Senai.OO.ProjetoFinal.Repositorio;

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
            if (Validacao.ValidarTexto(form["coment"]) == true)
            {
            comentario.DataCriacao = DateTime.Now;
            //Pegar o Id do Usuário Logado
            comentario.Usuario = HttpContext.Session.GetString ("idUsuario");
            comentario.Aprovacao = false;
            ComentarioRepositorio comentarioRep = new ComentarioRepositorio ();
            comentarioRep.Cadastrar (comentario);
            ViewBag.Mensagem = "Comentário cadastrado, aguarde a aprovação dos administradores";

            } else{
                ViewBag.Mensagem = "Mensagem inválida.";
            }
            return RedirectToAction ("index", "Comentario");
        }

        [HttpGet]
        public ActionResult aprovacao (int id) {
            if (HttpContext.Session.GetString ("TipoUsuario") == "usuario")
            {
                return RedirectToAction ("index", "Comentario");
            } else
            {
            ComentarioRepositorio ListaComentario = new ComentarioRepositorio ();
            ViewData["Comentarios"] = ListaComentario.Listar();
            return View ();
            }
        }
        [HttpPost]
        public ActionResult aprovacao(IFormCollection form) {
           ComentarioRepositorio comentarioRep = new ComentarioRepositorio();
            if (comentarioRep != null)
            {
               foreach (var item in comentarioRep)
               {
                   
               } 
            }
        return View();
        }

        [HttpGet]
        public IActionResult index(){
            ComentarioRepositorio ListaComentario = new ComentarioRepositorio ();
            ViewData["Comentarios"] = ListaComentario.Listar();
            return View ();
        }
        [HttpGet]
        public IActionResult sobre(){
            return View();
        }
        [HttpGet]
        public IActionResult Contato(){
            return View();
        }
        [HttpGet]
        public IActionResult perguntas(){
            return View();
        }
        [HttpGet]
        public IActionResult Listar () {
            ComentarioRepositorio comentarios = new ComentarioRepositorio ();
            ViewData["Comentarios"] = comentarios.Listar ();
            return View ();
        }
    }
}