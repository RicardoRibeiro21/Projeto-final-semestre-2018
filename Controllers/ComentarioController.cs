using System;
using Microsoft.AspNetCore.Mvc;
using Senai.OO.ProjetoFinal.Repositorio;
using System.IO;
using Microsoft.AspNetCore.Http;
using Senai.OO.ProjetoFinal.Models;
using System.Collections.Generic;

namespace Senai.OO.ProjetoFinal.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpGet] 
        public IActionResult index () {
            ComentarioRepositorio comentario = new ComentarioRepositorio();
            return View();
        }
        [HttpGet]
        public ActionResult Cadastrar(){
            //Verificar se tem alguém logado
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario"))){
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        } 
        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form){
            ComentarioModel comentario = new ComentarioModel(texto: form["coment"], id: 1);
            comentario.DataCriacao = DateTime.Now;
            //Pegar o Id do Usuário Logado
            comentario.Usuario = HttpContext.Session.GetString("idUsuario");
            comentario.Aprovacao = false;
             using(StreamWriter sw = new StreamWriter("comentarios.csv", true)){
                sw.WriteLine($"{comentario.Id};{comentario.Texto};{comentario.DataCriacao};{comentario.Usuario};{comentario.Aprovacao}");
            }

            ViewBag.Mensagem = "Comentário cadastrada, aguarde a aprovação dos administradores";
            
            return RedirectToAction("index", "Comentario");
        }
        [HttpGet]
        public ActionResult Aprovar (){
            return View();
        }
        // [HttpPost]
        // public ActionResult Aprovar(){

        // }
        // [HttpGet]
        // public List<ComentarioModel> Listar () {

        // }
    }
}