using System;

namespace FurnitureDEMO
{
    internal class Lamp : Furniture, IComparable<Lamp>
    {
        public double Current {  get; set; }

        public int CompareTo(Lamp? other)
        {
            return other != null
                    ? Current.CompareTo(other.Current)
                    : 1;
        }
        public override string ToString()
        {
            return $"Lampan {Name} drar {Current} amp";
        }
    }
}
