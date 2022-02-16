using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor_Movie
    {
        //One to Many
        public int MovieId { get; set; }

        //single  Movie
        public Movie Movie { get; set; }


        //One to Many
        public int ActorId { get; set; }

        //single  Actor
        public Actor Actor { get; set; }
    }
}
