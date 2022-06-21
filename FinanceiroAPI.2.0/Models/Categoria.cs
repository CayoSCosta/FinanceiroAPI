using System;
using System.Collections.Generic;

namespace FinanceiroAPI._2._0.Models
{
    public partial class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public bool Ativo { get; set; }
        public DateTime? DataInativado { get; set; }
        public int CriadoPor { get; set; }

        public virtual Usuario CriadoPorNavigation { get; set; } = null!;
    }
}
