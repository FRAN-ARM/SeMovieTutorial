
namespace SeMovieTutorial.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MovieDB/MovieGenres"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MovieGenresRow))]
    public class MovieGenresController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/MovieGenres/MovieGenresIndex.cshtml");
        }
    }
}