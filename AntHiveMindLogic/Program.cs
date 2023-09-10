namespace AntHiveMindLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeoGrid? geoGrid = GeoGrid.GetNewGeoGrid(5);

            geoGrid?.PlaceFoodAtRandomLocationOnGrid();
            geoGrid?.PlaceAntAtRandomLocationOnGrid();
        }
    }
}