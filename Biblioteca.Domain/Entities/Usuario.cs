using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Usuario
    {

        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }


    }
}
