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
    [RoutePrefix("emprestimo")]
    public class EmprestimoController : ApiController
    {

        [HttpGet]
        [Route("adicionar")]
        public HttpResponseMessage AddEmprestimo()
        {
            Emprestimo emprestimo = new Emprestimo();

            List<Livro> livros = null;

            Usuario usuario = null;

            emprestimo.DiaDevolucao = DateTime.Now.AddDays(5);
            emprestimo.DiaEmprestimo = DateTime.Now;

            using (var repository = new LivroRepository())
            {
                livros = repository.ListAll();
            }



            emprestimo.Livros = livros;

            emprestimo.Multa = 0;
            emprestimo.Quantidade = livros.Count();

            using (var repository = new UsuarioRepository())
            {
                usuario = repository.GetById(2);
            }


            emprestimo.Usuario = usuario;

            using (var repository = new EmprestimoRepository())
            {
                repository.MarkStates(System.Data.Entity.EntityState.Unchanged , emprestimo);
                repository.Add(emprestimo);
            }


            return Request.CreateResponse(HttpStatusCode.OK, "Adicionou");


        }


        [HttpGet]
        [Route("remover/{id}")]
        public HttpResponseMessage RemoveEmprestimo(int id)
        {

            Emprestimo emprestimo = null;

            using (var repository = new EmprestimoRepository())
            {
                emprestimo = repository.GetById(id);
                repository.MarkStates(System.Data.Entity.EntityState.Unchanged, emprestimo);
                repository.Remove(emprestimo);

            }

            return Request.CreateResponse(HttpStatusCode.OK, "Removeu");


        }

        [HttpGet]
        [Route("editar/{id}")]
        public HttpResponseMessage EditarEmprestimo()
        {




            return Request.CreateResponse(HttpStatusCode.OK, "Editou");


        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage ListarEmprestimos()
        {

            List<Emprestimo> emprestimos = null;

            using (var repository = new EmprestimoRepository())
            {
                emprestimos = repository.ListAll();

            }


            return Request.CreateResponse(HttpStatusCode.OK, emprestimos);


        }


        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetAutor(int id)
        {

            Emprestimo emprestimo = null;

            using (var repository = new EmprestimoRepository())
            {
                emprestimo = repository.GetById(id);

            }


            return Request.CreateResponse(HttpStatusCode.OK, emprestimo);


        }
    }
}
