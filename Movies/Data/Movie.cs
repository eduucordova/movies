using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class Movie
    {
        public Movie()
        {
            CastMembers = new List<CastMember>();
        }
        public int MovieId { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public byte[] Thumbnail { get; set; }

        public List<CastMember> CastMembers { get; set; }
    }
}
