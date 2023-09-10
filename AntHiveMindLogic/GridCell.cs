namespace AntHiveMindLogic
{
    internal class GridCell
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Ant? Ant { get; set; }
        public Food? Food { get; set; }

        public GridCell(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public override string ToString()
        {
            return "(X:" + XCoordinate + ",Y:" + YCoordinate + ")";
        }
    }
}