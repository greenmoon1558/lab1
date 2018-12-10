using System;
using System.Collections.Generic;

namespace lab1
{
    public partial class Cities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Countries Country { get; set; }
        public virtual Cinemas Cinemas { get; set; }
    }
}
