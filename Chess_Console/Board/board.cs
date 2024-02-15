

namespace Board
{
    class board
    {
        public int lines {get;set;}
        public int columns { get;set;}
        public Part[,] parts;

        public board(int lines, int columns) {
            this.lines = lines;
            this.columns = columns; 
            parts = new Part[lines, columns];
        }

        public Part part (int lines, int columns)
        {
            return parts[lines, columns];
        }

        public Part part (Position pos) {
            return parts[pos.line, pos.column];
        }

        public bool existPart(Position pos) {
            validatePosition(pos);
            return part(pos) != null;
        }

        public void placePart(Part p, Position pos)
        {
            if (existPart(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição!");
            }
            parts[pos.line, pos.column] = p;
            p.position = pos;
        }

        public bool validPosition(Position pos)
        {
            if (pos.line<0 || pos.line>=lines || pos.column>=columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Posição inválida");
            }
        }
    }
}
