using Board;

namespace chess
{
    class Castle : Part
    {
        public Castle(board tab, Color color) : base(tab, color) { }

        public override string ToString()
        {
            return "C";
        }
        private bool canMove(Position pos)
        {
            Part p = tab.part(pos); //erro
            return p == null || p.color != color;
        }
        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[tab.lines, tab.columns];

            Position pos = new Position(0, 0);

            // above
            pos.setValues(position.line - 1, position.column);
            while (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (tab.part(pos) != null && tab.part(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line - 1;
            }

            // below
            pos.setValues(position.line + 1, position.column);
            while (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (tab.part(pos) != null && tab.part(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line + 1;
            }

            // right
            pos.setValues(position.line, position.column + 1);
            while (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (tab.part(pos) != null && tab.part(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }

            // left
            pos.setValues(position.line, position.column - 1);
            while (tab.validPosition(pos) && canMove(pos)) //erro
            {
                mat[pos.line, pos.column] = true;
                if (tab.part(pos) != null && tab.part(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }


            return mat;

        }

    }
}
    