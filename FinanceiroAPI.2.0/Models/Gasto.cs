using System;
using System.Collections.Generic;

namespace FinanceiroAPI._2._0.Models
{
    public partial class Gasto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public DateTime? Data { get; set; }
        public bool? Ativo { get; set; }
        public bool? Recorrente { get; set; }
        public DateTime? DataInativado { get; set; }
        public int CriadoPor { get; set; }

        public virtual Usuario CriadoPorNavigation { get; set; } = null!;
    }
}
