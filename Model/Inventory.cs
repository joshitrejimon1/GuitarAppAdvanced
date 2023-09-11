using System;
using System.Collections.Generic;
using System.Linq;

namespace GuitarApp
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, BackWood backWood, TopWood topWood)
        {
            GuitarSpecs specs = new GuitarSpecs
            {
                GuitarBuilder = builder,
                Model = model,
                GuitarType = type,
                BackWood = backWood,
                TopWood = topWood
            };

            guitars.Add(new Guitar(serialNumber, price, specs));
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(GuitarSpecs searchSpecs)
        {
            return guitars.Where(guitar => IsMatch(searchSpecs, guitar.Specs)).ToList();
        }

        private bool IsMatch(GuitarSpecs searchSpecs, GuitarSpecs guitarSpecs)
        {
            return
                searchSpecs.GuitarBuilder == guitarSpecs.GuitarBuilder &&
                searchSpecs.Model == guitarSpecs.Model &&
                searchSpecs.GuitarType == guitarSpecs.GuitarType &&
                searchSpecs.BackWood == guitarSpecs.BackWood &&
                searchSpecs.TopWood == guitarSpecs.TopWood;
        }
    }
}
