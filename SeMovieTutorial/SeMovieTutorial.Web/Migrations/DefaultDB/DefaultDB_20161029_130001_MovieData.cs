using FluentMigrator;
using FluentMigrator.Infrastructure;
using System;

namespace SeMovieTutorial.Migrations.DefaultDB
{

    [Migration(20161029130001)]
    public class DefaultDB_20161029_130001_MovieData : AutoReversingMigration
    {
        public override void Up()
        {
            /*var animeMovies = new[]
            {
                new {
                    Title = "Spirited Away",
                    Description = "A magical journey by Studio Ghibli.",
                    Storyline = "A girl discovers a world of spirits and must free her parents.",
                    Year = 2001,
                    ReleaseDate = new DateTime(2001, 7, 20),
                    Runtime = 125
                },
                new {
                    Title = "Your Name",
                    Description = "A body-swapping romance with stunning visuals.",
                    Storyline = "Two teenagers share a mysterious connection that binds their fates.",
                    Year = 2016,
                    ReleaseDate = new DateTime(2016, 8, 26),
                    Runtime = 112
                },
                new {
                    Title = "Princess Mononoke",
                    Description = "A tale of humans and nature at war.",
                    Storyline = "A prince becomes involved in a struggle between forest gods and humans.",
                    Year = 1997,
                    ReleaseDate = new DateTime(1997, 7, 12),
                    Runtime = 134
                },
                new {
                    Title = "A Silent Voice",
                    Description = "A powerful story about bullying and redemption.",
                    Storyline = "A boy seeks forgiveness from the deaf girl he once bullied.",
                    Year = 2016,
                    ReleaseDate = new DateTime(2016, 9, 17),
                    Runtime = 129
                },
                new {
                    Title = "My Neighbor Totoro",
                    Description = "Two girls meet a forest spirit in postwar rural Japan.",
                    Storyline = "Satsuki and Mei move to the countryside and meet magical creatures.",
                    Year = 1988,
                    ReleaseDate = new DateTime(1988, 4, 16),
                    Runtime = 86
                },
                new {
                    Title = "Howl's Moving Castle",
                    Description = "A young girl is transformed into an old woman by a witch's curse.",
                    Storyline = "She finds refuge in a magical moving castle owned by the wizard Howl.",
                    Year = 2004,
                    ReleaseDate = new DateTime(2004, 11, 20),
                    Runtime = 119
                },
                new {
                    Title = "Weathering With You",
                    Description = "A boy meets a girl who can control the weather.",
                    Storyline = "In a rainy Tokyo, their powers come with a cost.",
                    Year = 2019,
                    ReleaseDate = new DateTime(2019, 7, 19),
                    Runtime = 112
                },
                new {
                    Title = "The Wind Rises",
                    Description = "A fictional biography of aircraft designer Jiro Horikoshi.",
                    Storyline = "His dreams of flight are challenged by the reality of war.",
                    Year = 2013,
                    ReleaseDate = new DateTime(2013, 7, 20),
                    Runtime = 126
                },
                new {
                    Title = "Nausicaä of the Valley of the Wind",
                    Description = "A princess fights to stop a war in a toxic post-apocalyptic world.",
                    Storyline = "She seeks harmony between humans and nature.",
                    Year = 1984,
                    ReleaseDate = new DateTime(1984, 3, 11),
                    Runtime = 117
                },
                new {
                    Title = "The Girl Who Leapt Through Time",
                    Description = "A high school girl gains the ability to time travel.",
                    Storyline = "She soon learns that her actions have consequences.",
                    Year = 2006,
                    ReleaseDate = new DateTime(2006, 7, 15),
                    Runtime = 98
                },
                new {
                    Title = "5 Centimeters Per Second",
                    Description = "A melancholic tale of love and distance.",
                    Storyline = "Two childhood friends drift apart over the years.",
                    Year = 2007,
                    ReleaseDate = new DateTime(2007, 3, 3),
                    Runtime = 63
                },
                new {
                    Title = "Tokyo Godfathers",
                    Description = "Three homeless people find an abandoned baby on Christmas Eve.",
                    Storyline = "Their search for the baby's parents leads to unexpected revelations.",
                    Year = 2003,
                    ReleaseDate = new DateTime(2003, 8, 30),
                    Runtime = 92
                },
                new {
                    Title = "The Tale of the Princess Kaguya",
                    Description = "A girl found inside a bamboo stalk grows into a beautiful woman.",
                    Storyline = "She must choose between earthly joys and a celestial origin.",
                    Year = 2013,
                    ReleaseDate = new DateTime(2013, 11, 23),
                    Runtime = 137
                },
                new {
                    Title = "Ponyo",
                    Description = "A goldfish princess wants to become human.",
                    Storyline = "Her transformation causes a natural imbalance.",
                    Year = 2008,
                    ReleaseDate = new DateTime(2008, 7, 19),
                    Runtime = 101
                },
                new {
                    Title = "Paprika",
                    Description = "A psychologist uses a dream machine to help patients.",
                    Storyline = "When the device is stolen, reality and dreams begin to merge.",
                    Year = 2006,
                    ReleaseDate = new DateTime(2006, 11, 25),
                    Runtime = 90
                }
            };

            foreach (var movie in animeMovies)
            {
                Insert.IntoTable("Movie").InSchema("mov").Row(movie);
            }*/

        }
    }
}