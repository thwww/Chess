using Board;

namespace chess
{
    class King : Part
    {
        public King(board tab, Color color) : base(tab, color) { }

        public override string ToString()
        {
            return "K";
        }

        private bool canMove(Position pos) {
            Part p = tab.part(pos);
            return p == null || p.color != color;
        }
        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[tab.lines, tab.columns];

            Position pos = new Position(0, 0);

            // above
            pos.setValues(position.line - 1, pos.column);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // NE
            pos.setValues(position.line - 1, pos.column + 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // right
            pos.setValues(position.line, pos.column + 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // SE
            pos.setValues(position.line + 1, pos.column + 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // below
            pos.setValues(position.line + 1, pos.column);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // SO
            pos.setValues(position.line + 1, pos.column - 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // left
            pos.setValues(position.line, pos.column - 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            // NO
            pos.setValues(position.line - 1, pos.column - 1);
            if (tab.validPosition(pos) && canMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            return mat;

        }


       }

   }
