using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ORMDal
{
    public partial class SingleGame
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int? UserId { get; set; }
        public DateTime? PlayingDate { get; set; }

        public virtual User Users { get; set; }
    }
}
