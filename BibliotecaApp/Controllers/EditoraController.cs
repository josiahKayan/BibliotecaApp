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
    public class EditoraController : ApiController
    {

        [HttpGet]
        [Route("adicionar")]
        public HttpResponseMessage AddAutor()
        {
            Editora editora = new Editora();

            editora.Nome = "Valer";

            return Request.CreateResponse(HttpStatusCode.OK, "Adicionou");


        }


        [HttpGet]
        [Route("remover/{id}")]
        public HttpResponseMessage RemoveEditora(int id)
        {

            Editora editora = null;

            using (var repository = new EditoraRepository())
            {
                editora = repository.GetById(id);

                repository.Remove(editora);

            }

            return Request.CreateResponse(HttpStatusCode.OK, "Removeu");


        }

        [HttpGet]
        [Route("editar/{id}")]
        public HttpResponseMessage EditarEditora()
        {




            return Request.CreateResponse(HttpStatusCode.OK, "Editou");


        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage ListarEditoras()
        {

            List<Editora> editoras = null;

            using (var repository = new EditoraRepository())
            {
                editoras = repository.ListAll();

            }


            return Request.CreateResponse(HttpStatusCode.OK, editoras);


        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetEditora(int id)
        {

            Editora editora = null;

            using (var repository = new EditoraRepository())
            {
                editora = repository.GetById(id);

            }


            return Request.CreateResponse(HttpStatusCode.OK, editora);


        }

    }
}
