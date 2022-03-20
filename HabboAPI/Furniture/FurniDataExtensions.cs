namespace HabboAPI.Furniture;

public static class FurniDataExtensions
{
    public static bool IsWallItem(this Furniture furniture) => furniture is WallFurniture;

    public static bool IsFloorFurniture(this Furniture furniture) => furniture is FloorFurniture;

    public static Furniture? Find(this FurniData furniData, string name) => furniData.FirstOrDefault(f => f.Name.Equals(name));

    public static List<Furniture> GetLine(this FurniData furniData, string furniLine) => furniData.Where(f => f.FurniLine.Equals(furniLine)).ToList();
}