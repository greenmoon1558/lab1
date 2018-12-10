using System;
using System.Collections.Generic;

namespace lab1
{
    public partial class Cinemas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual Cities IdNavigation { get; set; }
    }
}
