namespace Restaurant
{
    using System.Collections.Generic;

    using Simple.Web;
    using Simple.Web.Behaviors;

    [UriTemplate("/menu")]
    public class GetMenu : IGet, IOutput<List<MenuItem>>
    {
        public GetMenu()
        {
            this.Output = new List<MenuItem>
                {
                    new MenuItem { Name = "Latte", Price = 5.50m },
                    new MenuItem { Name = "Espresso", Price = 4.20m },
                };
        }

        public Status Get()
        {
            return 200;
        }

        public List<MenuItem> Output { get; private set; }
    }

    public class MenuItem
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}