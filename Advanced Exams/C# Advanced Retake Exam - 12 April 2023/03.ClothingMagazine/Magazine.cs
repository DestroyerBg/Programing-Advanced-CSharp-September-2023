using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public Cloth GetSmallestCloth()
        {
            var orderClothes = Clothes.OrderBy(c => c.Size);
            return orderClothes.ElementAt(0);
        }

        public Cloth GetCloth(string color)
        {
            return Clothes.Find(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            var orderClothes = Clothes.OrderBy(c => c.Size);
            result.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in orderClothes)
            {
                result.AppendLine(cloth.ToString());
            }
            return result.ToString().TrimEnd();
        }

        public bool RemoveCloth(string color)
        {
            if (Clothes.Any(c=>c.Color == color))
            {
                Clothes.Remove(Clothes.Find(c => c.Color == color));
                return true;
            }
            return false;
        }
    }
}
