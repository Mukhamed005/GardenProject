using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GardenLibrary
{
    public class Garden
    {
        public Address Address { get; set; }
        public string Owner { get; set; }
        public List<Flower> Flowers { get; set; }

        public Garden()
        {
            Flowers = new List<Flower>();
        }
        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }
        public void ShowAll()
        {
            foreach (var flower in Flowers)
            {
                flower.show();
            }
        }
    }


    public class Flower
    {
        public string title { get; set; }
        public string description { get; set; }

        public void show()
        {
            Console.WriteLine($"title:{title},description{description}");
        }
    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
}

