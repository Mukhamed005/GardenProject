using System;
using GardenLibrary;

Garden garden = new Garden
{  Address = new Address { Street = "Староватутинский", City = "Москва", Zipcode = "123" }, Owner = "Адам" };
garden.AddFlower(new Flower { title = "sgdse", description = "fbgdfre" });
Console.WriteLine("Flowers 8in the gaden");
garden.ShowAll();
Console.ReadKey();