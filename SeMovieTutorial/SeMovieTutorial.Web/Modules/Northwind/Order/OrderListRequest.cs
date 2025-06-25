using Serenity.Services;

namespace SeMovieTutorial.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}