using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MP2.Models
{
    public class SongViewModel
    {
        public int SongID { get; set; }
        public string SongTitle { get; set; }
        public string SongDuration { get; set; }
        public int ArtistID { get; set; }
        public int AlbumID { get; set; }
        public string FilePath { get; set; }
        
    }
}