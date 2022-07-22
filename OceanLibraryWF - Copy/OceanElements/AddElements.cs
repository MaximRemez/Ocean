namespace OceanLibrary
{
    public class AddElements
    {
        readonly Randomizer randomizer = new Randomizer();

        public void AddOceanElements(Ocean addElements)
        {
            AddEmptyCells(addElements);
            AddObstacles(addElements);
            AddPrey(addElements);
            AddPredators(addElements);
            AddRimuru(addElements);
        }

        private Coordinate GetEmptyCellCoord(Ocean addMembers)
        {
            int x, y;
            Coordinate empty;

            do
            {
                x = randomizer.RandNum(addMembers.NumCols);
                y = randomizer.RandNum(addMembers.NumRows);
            }
            while (addMembers.cells[y, x].Image != Constant.defaultCellImage);

            empty = addMembers.cells[y, x].Offset;
            return empty;
        }

        private void AddEmptyCells(Ocean addMembers)
        {
            for (int row = 0; row < addMembers.NumRows; row++)
            {

                for (int column = 0; column < addMembers.NumCols; column++)
                {
                    Coordinate coord = new Coordinate(column, row);
                    Cell temp = new Cell(coord, addMembers);
                    addMembers.cells[row, column] = temp;
                }

            }
        }

        private void AddObstacles(Ocean addMembers)
        {
            Coordinate empty;

            for (int i = 0; i < addMembers.NumObstacle; i++)
            {
                empty = GetEmptyCellCoord(addMembers);
                addMembers.cells[empty.Y, empty.X] = new Obstacle(empty, addMembers);
            }

        }

        private void AddPrey(Ocean addMembers)
        {
            Coordinate empty;

            for (int i = 0; i < addMembers.NumPrey; i++)
            {
                empty = GetEmptyCellCoord(addMembers);
                addMembers.cells[empty.Y, empty.X] = new Prey(empty, addMembers, Constant.defaultTimeToReproduce);
            }

        }

        private void AddPredators(Ocean addMembers)
        {
            Coordinate empty;

            for (int i = 0; i < addMembers.NumPredator; i++)
            {
                empty = GetEmptyCellCoord(addMembers);
                addMembers.cells[empty.Y, empty.X] = new Predator(empty, addMembers, Constant.defaultTimeToReproduce, Constant.defaultTimeToFeed);
            }

        }

        private void AddRimuru(Ocean addMembers)
        {
            Coordinate empty;

            for (int i = 0; i < addMembers.NumRimuruFish; i++)
            {
                empty = GetEmptyCellCoord(addMembers);
                addMembers.cells[empty.Y, empty.X] = new RimuruFish(empty, addMembers);
            }
        }
    }
}
