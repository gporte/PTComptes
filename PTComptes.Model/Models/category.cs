using System;
using System.Collections.Generic;

namespace PTComptes.Model.Models
{
    public partial class category
    {
        public category()
        {
            this.operations = new List<operation>();
        }

        public long Id { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<operation> operations { get; set; }
    }
}
