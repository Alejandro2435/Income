using INCOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INCOME.Models.ModeloUsuarios;

namespace INCOME.Controllers
{
    public class PerfilController : Controller
    {
        //GET: Perfil
        public ActionResult Perfil()
        {
            //int iduser = (int)Session["IdUser"];
            int iduser = 2;
            List<ModUsuarios> lst;
            using (INCOMEEntities2 db = new INCOMEEntities2())
            {
                lst = (from dato in db.Usuarios
                       where dato.IdUser == iduser
                       select new ModUsuarios
                       {
                           Nombre = dato.nombre,
                           Username = dato.username,
                           Email = dato.email

                       }).ToList();
            }

            return View(lst);
        }

        //public ActionResult ObtenerPerfil()
        //{
        //    //int iduser = (int)Session["IdUser"];
        //    int iduser = 1;
        //    List<ModUsuarios> lst;
        //    //string usuario;
        //    using (INCOMEEntities2 db = new INCOMEEntities2())
        //    {
        //        lst = (from dato in db.Usuarios
        //               where dato.IdUser == iduser
        //               select new ModUsuarios
        //               {
        //                   Nombre = dato.nombre,
        //                   Username = dato.username,
        //                   Email = dato.email

        //               }).ToList();
        //        //usuario = (from dato in db.Usuarios
        //        //           where dato.username == UserName
        //        //           select dato.nombre).ToString();
        //    }
        //    return View(lst);
        //}

        //public ActionResult ActualizarInfo(string UserName)
        //{
        //    ModUsuarios usuarios = new ModUsuarios();
        //    using (INCOMEEntities2 db = new INCOMEEntities2())
        //    {
        //        var usuarios=db.Usuarios.Find()
        //    }
        //}


        //[HttpPost]
        //public ActionResult ActualizarInfo()
        //{
        //    string nombre = Request.Form["name"].ToString();
        //    string email = Request.Form["email"].ToString();

        //    using(INCOMEEntities2 db=new INCOMEEntities2())
        //    {
        //        var usuario = (from datos in db.Usuarios
        //                       where datos.username == Username
        //                       select datos).FirstOrDefault();

        //        ModUsuarios usuario = new ModUsuarios();

        //        usuario.Nombre = nombre;
        //        usuario.Email = email;

        //        db.SaveChanges();
        //    }

        //    return PartialView("View_ActualizarInfo");
        //}
    }
}