using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Emprestimo
    {

        [Key]
        public int EmprestimoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DiaEmprestimo { get; set; }
        public DateTime DiaDevolucao { get; set; }
        public int Multa { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
        public virtual Usuario Usuario { get; set; }


    }
}
