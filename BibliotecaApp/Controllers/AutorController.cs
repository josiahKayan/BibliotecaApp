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
    public class AutorController : ApiController
    {

        [HttpGet]
        [Route("adicionar")]
        public HttpResponseMessage AddAutor()
        {
            Autor autor = new Autor();

            autor.Nome = "Josias";

            return Request.CreateResponse(HttpStatusCode.OK, "Adicionou");


        }


        [HttpGet]
        [Route("remover/{id}")]
        public HttpResponseMessage RemoveAutor(int id)
        {

            Autor autor = null;

            using (var repository = new AutorRepository())
            {
                autor = repository.GetById(id);

                repository.Remove(autor);

            }

            return Request.CreateResponse(HttpStatusCode.OK, "Removeu");


        }

        [HttpGet]
        [Route("editar/{id}")]
        public HttpResponseMessage EditarAutor()
        {




            return Request.CreateResponse(HttpStatusCode.OK, "Editou");


        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage ListarAutores()
        {

            List<Autor> autores = null;

            using (var repository = new AutorRepository())
            {
                autores = repository.ListAll();

            }


            return Request.CreateResponse(HttpStatusCode.OK, autores);


        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetAutor(int id)
        {

            Autor autor = null;

            using (var repository = new AutorRepository())
            {
                autor = repository.GetById(id);

            }


            return Request.CreateResponse(HttpStatusCode.OK, autor);


        }

    }
}
