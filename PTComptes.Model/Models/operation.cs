using System;
using System.Collections.Generic;

namespace PTComptes.Model.Models
{
    public partial class Operation
    {
        public long Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string Libelle { get; set; }
        public long CategorieId { get; set; }
        public long TiersId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}
