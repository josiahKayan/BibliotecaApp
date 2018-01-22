using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }
        public int Isbn { get; set; }
        public string Titulo { get; set; }
        public int Edicao { get; set; }
        public  Editora Editora { get; set; }
        public virtual ICollection<Autor> Autor { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }


    }
}
