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
    }
}
