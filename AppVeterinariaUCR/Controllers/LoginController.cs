
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppVeterinariaUCR.Models;
using AppVeterinariaUCR.Data;
using Microsoft.IdentityModel;

//Librerias para utulizar la autenticacion por formulario
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;


namespace AppVeterinariaUCR.Controllers
{
    public class LoginController : Controller
    {
        private VeterinariaContext context;

        //Constructor con parametros que recibe la instancia contexto 
        public LoginController(VeterinariaContext cnt)
        {
            this.context = cnt;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind] Usuarios user)
        {
            try
            {
                var temp = this.ValidarUsuario(user);

                //se pregunta si el usuario se valido correctamente 
                if (temp != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, temp.Login),
                        new Claim(ClaimTypes.Email, temp.Email),
                    };

                    var grandIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { grandIdentity });

                    HttpContext.SignInAsync(userPrincipal);

                    return RedirectToAction("Index", "Home");
                }
                TempData["mensaje"] = "Error usurario o password incorrecto";
                return View(user);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public IActionResult CrearCuenta()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult CrearCuenta([Bind] Usuarios usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario.Password = this.generarClave();

                    this.context.Usuarios.Add(usuario);

                    this.context.SaveChanges();

                    Email email = new Email();
                    email.enviar(usuario, @"wwwroot/css/img/FirmaVeterinaria.jpg");

                    TempData["mensaje"] = "Usuario creado correctamente.";

                    return RedirectToAction("CrearCuenta");
                }
                else
                {
                    TempData["mensaje"] = "No se logro crear el usuario";
                    return View(usuario);
                }

            }
            catch (Exception ex)
            {
                //TempData["mensaje"] = "Error " + ex.Message;
                TempData["mensaje"] = "El  usuario ya existe";
                return View(usuario);
            }


        }

        private string generarClave()
        {
            try
            {
                Random random = new Random();
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Programacion del 31 de mayo hora 14:07
        private Usuarios ValidarUsuario(Usuarios temp)
        {
            Usuarios autorizado = null;

            //aqui se valida el login 
            var user = this.context.Usuarios.FirstOrDefault(u => u.Login == temp.Login);

            //aqui se pregunta si existe un usurio 
            if (user != null)
            {
                //se confirma la contrase;a
                if (user.Password.Equals(temp.Password))
                {
                    autorizado = user;
                }
            }

            return autorizado;

        }


        public  async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");

        }

        [HttpGet]
        public IActionResult cambioClave()
        {
            return View();
        }

        


    }
}
