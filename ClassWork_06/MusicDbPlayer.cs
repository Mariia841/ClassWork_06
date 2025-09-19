using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_06
{
    internal class MusicDbPlayer
    {

        public MusicDbPlayer()
        {
        
        }

        
    }

    class Artists
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sruname { get; set; }
        public string Country { get; set; }
        

    }

    class Albums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int ArtistId { get; set; }
    }
    class Tracks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AlbumId { get; set; }
    }

    class Playlists
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TracksId { get; set; }

    }

    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
