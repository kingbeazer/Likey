using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Likey.Models;

namespace Likey.Viewmodels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<User> Users { get; set; }
    }
}