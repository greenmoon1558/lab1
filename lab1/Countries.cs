using System;
using System.Collections.Generic;

namespace lab1
{
    public partial class Countries
    {
        public Countries()
        {
            Cities = new HashSet<Cities>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cities> Cities { get; set; }
    }
}
