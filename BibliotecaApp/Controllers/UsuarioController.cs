using Biblioteca.Domain.Entities;
using Biblitoca.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BibliotecaApp.Controllers
{
    [RoutePrefix("usuarios")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("adicionar")]
        public HttpResponseMessage AddUsuario()
        {
            Usuario usuario = new Usuario();

            usuario.Nome = "Josias";

            return Request.CreateResponse(HttpStatusCode.OK, "Adicionou");


        }


        [HttpGet]
        [Route("remover/{id}")]
        public HttpResponseMessage RemoveUsuario(int id)
        {

            Usuario usuario = null;

            using (var repository = new UsuarioRepository())
            {
                usuario = repository.GetById(id);

                repository.Remove(usuario);

            }

            return Request.CreateResponse(HttpStatusCode.OK, "Removeu");


        }

        [HttpGet]
        [Route("editar/{id}")]
        public HttpResponseMessage EditarUsuario()
        {




            return Request.CreateResponse(HttpStatusCode.OK, "Editou");


        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage ListarUsuarios()
        {

            List<Usuario> usuarios = null;

            using (var repository = new UsuarioRepository())
            {
                usuarios = repository.ListAll();

            }


            return Request.CreateResponse(HttpStatusCode.OK, usuarios);


        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetUsuario( int id)
        {

            Usuario usuario = null;

            using (var repository = new UsuarioRepository())
            {
                usuario = repository.GetById(id);

            }


            return Request.CreateResponse(HttpStatusCode.OK, usuario);


        }


    }
}
