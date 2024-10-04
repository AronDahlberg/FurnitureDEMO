using System;

namespace FurnitureDEMO
{
    internal class Table:Furniture, IComparable<Table>
    {
        public double AreaOfTable { get; set; }

        public int CompareTo(Table? other)
        {
            return other != null
                    ? AreaOfTable.CompareTo(other.AreaOfTable)
                    : 1;
        }
        public override string ToString()
        {
            return $"Bordet {Name} har ytan {AreaOfTable}";
        }
    }
}
