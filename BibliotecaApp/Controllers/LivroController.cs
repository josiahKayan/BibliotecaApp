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
    public class LivroController : ApiController
    {

        [HttpGet]
        [Route("adicionar")]
        public HttpResponseMessage AddLivro()
        {
            Livro livro = new Livro();

            livro.Isbn = 12334;
            livro.Titulo = "As Crõnicas de Nárnia";

            return Request.CreateResponse(HttpStatusCode.OK, "Adicionou");


        }


        [HttpGet]
        [Route("remover/{id}")]
        public HttpResponseMessage RemoveLivro(int id)
        {

            Livro livro = null;

            using (var repository = new LivroRepository())
            {
                livro = repository.GetById(id);

                repository.Remove(livro);

            }

            return Request.CreateResponse(HttpStatusCode.OK, "Removeu");


        }

        [HttpGet]
        [Route("editar/{id}")]
        public HttpResponseMessage EditarLivro()
        {




            return Request.CreateResponse(HttpStatusCode.OK, "Editou");


        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage ListarLivros()
        {

            List<Livro> livros = null;

            using (var repository = new LivroRepository())
            {
                livros = repository.ListAll();

            }


            return Request.CreateResponse(HttpStatusCode.OK, livros);


        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetLivro(int id)
        {

            Livro livro = null;

            using (var repository = new LivroRepository())
            {
                livro = repository.GetById(id);

            }


            return Request.CreateResponse(HttpStatusCode.OK, livro);


        }
    }
}
