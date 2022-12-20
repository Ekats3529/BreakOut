using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SingleGame
    {
        public int Id { get; set; }
        public DateTime? PlayingDate { get; set; }
        public int? UserId { get; set; }
        public int Score { get; set; }
    }
}
