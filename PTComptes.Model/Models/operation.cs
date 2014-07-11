using System;
using System.Collections.Generic;

namespace PTComptes.Model.Models
{
    public partial class operation
    {
        public long Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string Libelle { get; set; }
        public long CategorieId { get; set; }
        public long TiersId { get; set; }
        public virtual category category { get; set; }
        public virtual tier tier { get; set; }
    }
}
