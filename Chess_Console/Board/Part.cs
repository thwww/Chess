
namespace Board
{
    class Part
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int amtmovements { get; protected set; }
        public board tab { get; protected set; }

        public Part(Position position, board tab, Color color)
        {
            this.position = position;
            this.tab = tab;
            this.color = color;
            this.amtmovements = 0;
        }
    }
}
