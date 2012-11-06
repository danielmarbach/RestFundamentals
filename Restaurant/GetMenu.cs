namespace Restaurant
{
    using System;
    using System.Collections.Generic;

    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Http;

    [UriTemplate("/menu")]
    public class GetMenu : IGet, IOutput<List<MenuItem>>, IModified, ICacheability
    {
        public GetMenu()
        {
            var utcNow = DateTime.UtcNow;

            this.LastModified = new DateTime(utcNow.Year, utcNow.Month, utcNow.Day, 0, 0, 0, DateTimeKind.Utc);
            this.IfModifiedSince = new DateTime(utcNow.Year, utcNow.Month, utcNow.Day, 1, 0, 0, DateTimeKind.Utc);

            this.CacheOptions = new CacheOptions(this.LastModified.Value.Add(TimeSpan.FromDays(1)))
                {
                    Level = CacheLevel.Private
                };
  
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

        public DateTime? IfModifiedSince { set; private get; }

        public DateTime? LastModified { get; private set; }

        public CacheOptions CacheOptions { get; private set; }
    }

    public class MenuItem
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}