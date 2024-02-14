

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
    }
}
