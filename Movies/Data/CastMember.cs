using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class CastMember
    {
        public int CastMemberId { get; set; }
        public string ActorName { get; set; }
        public string CharacterName { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
