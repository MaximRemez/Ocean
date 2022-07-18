namespace OceanLibrary
{
    public class CardinalDirections
    {

        public Cell GetNorthCell(Coordinate anOffset, Ocean direction)
        {
            if (anOffset.Y <= 0)
            {
                return direction.cells[anOffset.Y, anOffset.X];
            }

            else
            {
                Coordinate coord = new Coordinate(anOffset.X, anOffset.Y - 1);

                return direction.GetCellAt(coord);
            }
        }

        public Cell GetEastCell(Coordinate anOffset, Ocean direction)
        {
            if (anOffset.X >= (Constant.maxCols - 1))
            {
                return direction.cells[anOffset.Y, anOffset.X];
            }

            else
            {
                Coordinate coord = new Coordinate(anOffset.X + 1, anOffset.Y);

                return direction.GetCellAt(coord);
            }
        }

        public Cell GetWestCell(Coordinate anOffset, Ocean direction)
        {
            if (anOffset.X <= 0)
            {
                return direction.cells[anOffset.Y, anOffset.X];
            }

            else
            {
                Coordinate coord = new Coordinate(anOffset.X - 1, anOffset.Y);

                return direction.GetCellAt(coord);
            }
        }

        public Cell GetSouthCell(Coordinate anOffset, Ocean direction)
        {
            if (anOffset.Y >= (Constant.maxRows - 1))
            {
                return direction.cells[anOffset.Y, anOffset.X];
            }

            else
            {
                Coordinate coord = new Coordinate(anOffset.X, anOffset.Y + 1);

                return direction.GetCellAt(coord);
            }
        }
    }
}
