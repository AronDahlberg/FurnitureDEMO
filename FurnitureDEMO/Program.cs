namespace FurnitureDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Table> tables = ExampleTableData(random, 4, 7);
            List<Lamp> lamps = ExampleLampData(random, 4, 7);

            tables.Sort();
            lamps.Sort();

            foreach (Table table in tables)
            {
                Console.WriteLine(table.ToString());
            }

            foreach (Lamp lamp in lamps)
            {
                Console.WriteLine(lamp.ToString());
            }

        }
        private static List<Table> ExampleTableData(Random random, int lowerBoundAmount, int upperBoundAmount)
        {
            List<Table> tables = [];

            int Amount = random.Next(lowerBoundAmount, upperBoundAmount);
            for (int i = 0; i < Amount; i++)
            {
                Table table = new();

                switch (random.Next(1, 3))
                {
                    case 1:
                        table.TypeOfFurniture = TypeOfFurniture.Bord;
                        break;
                    case 2:
                        table.TypeOfFurniture = TypeOfFurniture.Skrivbord;
                        break;
                }

                RandomMatrial(random, table);

                table.Name = FurnitureNames.Names[random.Next(FurnitureNames.Names.Count)];

                table.AreaOfTable = random.NextDouble() * 100;

                tables.Add(table);
            }

            return tables;
        }
        private static List<Lamp> ExampleLampData(Random random, int lowerBoundAmount, int upperBoundAmount)
        {
            List<Lamp> lamps = [];

            int Amount = random.Next(lowerBoundAmount, upperBoundAmount);
            for (int i = 0; i < Amount; i++)
            {
                Lamp lamp = new();

                switch (random.Next(1, 3))
                {
                    case 1:
                        lamp.TypeOfFurniture = TypeOfFurniture.Taklampa;
                        break;
                    case 2:
                        lamp.TypeOfFurniture = TypeOfFurniture.Bordslampa;
                        break;
                }

                RandomMatrial(random, lamp);

                lamp.Name = FurnitureNames.Names[random.Next(FurnitureNames.Names.Count)];

                lamp.Current = random.NextDouble() * 40;

                lamps.Add(lamp);
            }

            return lamps;
        }
        private static void RandomMatrial(Random random, Furniture furniture)
        {
            switch (random.Next(1, 4))
            {
                case 1: furniture.Wood = true; break;
                case 2: furniture.Steel = true; break;
                case 3: furniture.Fabric = true; break;
            }
        }
    }
}
