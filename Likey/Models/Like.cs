using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Likey.Models
{
    public class Like
    {
        public int  Id { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public byte Rating { get; set; }
    }
}