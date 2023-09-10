namespace AntHiveMindLogic
{
    internal class GeoGrid
    {
        public List<GridRow>? Rows { get; set; }
        public List<GridColumn>? Columns { get; set; }
        public List<GridCell>? Cells { get; set; }

        public GeoGrid()
        {
            Rows = new List<GridRow>();
            Columns = new List<GridColumn>();
        }

        public void PlaceAntAtRandomLocationOnGrid()
        {
            if (!(Cells is null))
            {
                var cells = Cells.Where(x => x.Food is null).ToList();
                var cell = cells.ElementAt(new Random().Next(0, cells.Count - 1));
                Console.WriteLine("Placing an ant at: " + cell.ToString());
            }
        }

        public void PlaceFoodAtRandomLocationOnGrid()
        {
            if (!(Cells is null))
            {
                var cells = Cells.Where(x => x.Ant is null).ToList();
                var cell = cells.ElementAt(new Random().Next(0, cells.Count - 1));
                Console.WriteLine("Placing food at: " + cell.ToString());
            }
        }

        public void RunSimulationAsync(int iterations)
        {

        }

        public static GeoGrid? GetNewGeoGrid(int gridSize)
        {
            GeoGrid geoGrid = new GeoGrid();

            List<GridCell> cells = new List<GridCell>();

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    GridCell cell = new GridCell(i + 1, j + 1);

                    cells.Add(cell);
                }
            }

            geoGrid.Cells = cells;

            for (int i = 0; i < gridSize; i++)
            {
                GridRow row = new GridRow();
                row.GridCells = cells.Where(x => x.XCoordinate == i + 1).ToList();
                geoGrid?.Rows?.Add(row);

                GridColumn column = new GridColumn();
                column.GridCells = cells.Where(x => x.YCoordinate == i + 1).ToList();
                geoGrid?.Columns?.Add(column);
            }

            return geoGrid;
        }
    }
}
