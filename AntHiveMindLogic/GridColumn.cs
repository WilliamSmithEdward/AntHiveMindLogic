namespace AntHiveMindLogic
{
    internal class GridColumn
    {
        public List<GridCell>? GridCells { get; set; }

        public override string ToString()
        {
            return string.Join(", ", (GridCells ?? Enumerable.Empty<GridCell>()).Select(x => x.ToString()));
        }
    }
}
