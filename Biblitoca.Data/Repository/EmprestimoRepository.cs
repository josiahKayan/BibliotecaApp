using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblitoca.Data.Repository
{
    public class EmprestimoRepository : RepositoryBase<Emprestimo>, IDisposable
    {

        public List<Emprestimo> ListarEmprestimos()
        {
            return this.bibliotecaContext.Set<Emprestimo>().Include("Usuario").Include("Livros.Editora").Include("Livros.Autor").ToList();

        }


    }
}
