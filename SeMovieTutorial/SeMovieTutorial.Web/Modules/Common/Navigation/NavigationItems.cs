using Serenity.Navigation;
using Administration = SeMovieTutorial.Administration.Pages;
using MovieDB = SeMovieTutorial.MovieDB.Pages;
using Northwind = SeMovieTutorial.Northwind.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

// Custom
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MovieDB.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(2200, "Movie Database/Genres", typeof(MovieDB.GenreController), icon: "fa-filter")]
[assembly: NavigationLink(2200, "Movie Database/Movie Genres", typeof(MovieDB.MovieGenresController), icon: "fa-file")]
[assembly: NavigationLink(2200, "Movie Database/Person", typeof(MovieDB.PersonController), icon: "fa-user")]

//-------

[assembly: NavigationMenu(8000, "Northwind", icon: "fa-anchor")]

[assembly: NavigationLink(8200, "Northwind/Customers",
typeof(Northwind.CustomerController), icon: "fa-credit-card")]

[assembly: NavigationLink(8300, "Northwind/Products",
typeof(Northwind.ProductController), icon: "fa-cube")]