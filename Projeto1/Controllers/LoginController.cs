﻿using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;
using Projeto1.Models;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        //construtor
        private readonly UsuarioRepositorio _usuarioRepositorio;
        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = UsuarioRepositorio.ObterUsuario(email);
            if (usuario != null && usuario.Senha = senha)
            {
                //Autenticação bem-sucedida
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Email ou senha inválidos");
            return View();
        }

        public IActionResult Cadastro() 
        {  
            return View();
        }


        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _usuarioRepositorio.AdicionarUsuario(usuario);
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
    }
}