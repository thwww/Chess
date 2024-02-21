
namespace Board
{
    abstract class Part
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int amtmovements { get; protected set; }
        public board tab { get; protected set; }

        public Part(board tab, Color color)
        {
            this.position = null;
            this.tab = tab;
            this.color = color;
            this.amtmovements = 0;
        }

        public abstract bool[,] possibleMovements();

        public void increaseAmtMovements() { 
            amtmovements++;
        }
    }
}
