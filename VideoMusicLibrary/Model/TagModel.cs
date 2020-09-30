using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TagLib;

namespace VideoMusicLibrary.Model
{
    public class TagModel
    {
        public string FilePath { get; set; }
        public string TitleToShow
        {
            get
            {
                return Path.GetFileNameWithoutExtension(FilePath);
            }
        }
        public string Extension 
        {
            get
            {
                return Path.GetExtension(FilePath);
            }

        }

        public string TrackTitle { get; set; }
        public string Artist { get; set; }
        public string AlbumArtist { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }

        private TagLib.File fileTag;
        private Tag tag;

        public TagModel(string path)
        {
            FilePath = path;
            fileTag = TagLib.File.Create(path);
            tag = fileTag.Tag;
            TrackTitle = tag.Title;
            Artist = tag.Performers.Length == 0 ? string.Empty : tag.Performers.ToString();
            AlbumArtist = tag.AlbumArtists.Length == 0 ? string.Empty : tag.AlbumArtists.ToString();
            Genre = tag.Genres.Length == 0 ? string.Empty : tag.Genres.ToString();
            Album = tag.Album;
        }

        public void Save()
        {
            tag.Title = TrackTitle;
            tag.Performers = Artist.Split(", ".ToCharArray());
            tag.AlbumArtists = AlbumArtist.Split(", ".ToCharArray());
            tag.Genres = Genre.Split(", ".ToCharArray());
            tag.Album = Album;
            fileTag.Save();
        }

        public override string ToString() => $"{Artist} - {TitleToShow}";
    }
}
