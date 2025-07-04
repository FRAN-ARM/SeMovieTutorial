﻿
namespace SeMovieTutorial.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using MovieTutorial.MovieDB;

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        [Width(100), QuickFilter]
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        /*[Width(100), QuickFilter]
        public String GenreName { get; set; }*/
        [Width(200), GenreListFormatter, QuickFilter]

        public List<Int32> GenreList { get; set; }
        [DisplayName("Runtime in Minutes"), Width(150), AlignCenter]
        public Int32 Runtime { get; set; }
        public MovieKind Kind { get; set; }
}
}