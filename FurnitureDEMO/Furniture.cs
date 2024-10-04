namespace FurnitureDEMO
{
    internal abstract class Furniture
    {
        public bool Wood { get; set; }
        public bool Steel { get; set; }
        public bool Fabric { get; set; }
        public TypeOfFurniture TypeOfFurniture { get; set; }
        public string Name { get; set; } = "";
    }
}
