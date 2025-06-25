
namespace SeMovieTutorial.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MovieDB.MovieGenres")]
    [BasedOnRow(typeof(Entities.MovieGenresRow), CheckNames = true)]
    public class MovieGenresColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieGenreId { get; set; }
        public String MovieTitle { get; set; }
        public String GenreName { get; set; }
    }
}