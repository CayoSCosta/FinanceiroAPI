using System;
using System.Collections.Generic;

namespace FinanceiroAPI._2._0.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Categoria = new HashSet<Categoria>();
            Entrada = new HashSet<Entrada>();
            Gastos = new HashSet<Gasto>();
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string Email { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public int CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public int? CargoId { get; set; }

        public virtual Cargo? Cargo { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
