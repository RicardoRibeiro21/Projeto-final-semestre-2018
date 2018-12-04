using System;
using Microsoft.AspNetCore.Mvc;
using Senai.OO.ProjetoFinal.Repositorio;
using System.IO;
using Microsoft.AspNetCore.Http;
namespace Senai.OO.ProjetoFinal.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpGet] 
        public IActionResult index () {
            ComentarioRepositorio comentario = new ComentarioRepositorio();
            return View();
        }
    }
}