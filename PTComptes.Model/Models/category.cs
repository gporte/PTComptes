using System;
using System.Collections.Generic;

namespace PTComptes.Model.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Operations = new List<Operation>();
        }

        public long Id { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
