namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    using System.Drawing.Imaging;
    using System.IO;

    using Simple.Web;
    using Simple.Web.Behaviors;
    using Simple.Web.Http;

    [UriTemplate("/menu")]
    public class GetMenu : IGet, IOutput<List<MenuItem>>, IModified, ICacheability
    {
        public GetMenu()
        {
            var utcNow = DateTime.UtcNow;

            this.LastModified = utcNow.Subtract(TimeSpan.FromDays(2));

            this.CacheOptions = new CacheOptions(utcNow.Add(TimeSpan.FromDays(1)))
                {
                    Level = CacheLevel.Private,
                };
  
            this.Output = new List<MenuItem>
                {
                    new MenuItem { Name = "Assorted Dry Cereals", Price = 5.50m },
                    new MenuItem { Name = "Steamed Wheat", Price = 4.20m },
                    new MenuItem { Name = "1 Scrambled Egg", Price = 1.50m },
                    new MenuItem { Name = "2 Milk", Price = 2.65m },
                    new MenuItem { Name = "Stewed Fruit", Price = 1m },
                    new MenuItem { Name = "Toast", Price = 1m },
                    new MenuItem { Name = "Bread", Price = 1m },
                    new MenuItem { Name = "Butter", Price = 0.50m },
                    new MenuItem { Name = "Coffee", Price = 4.20m },
                };
        }

        public Status Get()
        {
            if (this.IfModifiedSince.HasValue && this.IfModifiedSince.Value > this.LastModified)
            {
                return 304;
            }

            return 200;
        }

        public List<MenuItem> Output { get; private set; }

        public DateTime? IfModifiedSince { set; private get; }

        public DateTime? LastModified { get; private set; }

        public CacheOptions CacheOptions { get; private set; }
    }

    [UriTemplate("/menu")]
    [RespondsWith("image/png")]
    public class GetMenuAsImage : IGet, IOutputStream
    {
        public string ContentType
        {
            get { return "image/png"; }
        }

        public string ContentDisposition { get; private set; }

        public Stream Output
        {
            get
            {
                var stream = new MemoryStream();
                Menu.menu.Save(stream, ImageFormat.Png);
                return stream;
            }
        }

        public Status Get()
        {
            return 200;
        }
    }

    public class MenuItem
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}