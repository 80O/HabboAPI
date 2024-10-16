namespace HabboAPI.Furniture;

public static class FurniDataExtensions
{
    public static bool IsWallItem(this Furniture furniture) => furniture is WallFurniture;

    public static bool IsFloorFurniture(this Furniture furniture) => furniture is FloorFurniture;

    public static Furniture? Find<TFurniType>(this FurniData furniData, string name) where TFurniType : Furniture => furniData.Furniture.OfType<TFurniType>().FirstOrDefault(f => f.Name.Equals(name));

    public static List<Furniture> GetLine(this FurniData furniData, string furniLine) => furniData.Furniture.Where(f => f.FurniLine.Equals(furniLine)).ToList();
}