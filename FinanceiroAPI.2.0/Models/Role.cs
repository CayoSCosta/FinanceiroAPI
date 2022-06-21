using System;
using System.Collections.Generic;

namespace FinanceiroAPI._2._0.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Rolename { get; set; } = null!;
        public int? UserId { get; set; }
        public int CriadoPor { get; set; }
        public bool Ativo { get; set; }

        public virtual Usuario? User { get; set; }
    }
}
