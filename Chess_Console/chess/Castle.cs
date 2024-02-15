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
    }
}
