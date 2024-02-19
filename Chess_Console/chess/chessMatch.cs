using Board;
using System;


namespace chess
{
    internal class chessMatch
    {
        public board tab {  get; private set; }
        private int shift;
        private Color currentPlayer;
        public bool finished {  get; private set; }

        public chessMatch() { 
            tab = new board(8, 8);
            shift = 1;
            currentPlayer = Color.White;
            finished = false;
            placeParts();
        }

        public void performMovement(Position origin, Position destiny)
        {
            Part p = tab.removePart(origin);
            p.increaseAmtMovements();
            Part capturedPart = tab.removePart(destiny);
            tab.placePart(p, destiny);
        }

        public void placeParts()
        {
            tab.placePart(new Castle(tab, Color.White), new chessPosition('c', 1).toPosition());
            tab.placePart(new Castle(tab, Color.White), new chessPosition('c', 2).toPosition());
            tab.placePart(new Castle(tab, Color.White), new chessPosition('d', 2).toPosition());
            tab.placePart(new Castle(tab, Color.White), new chessPosition('e', 2).toPosition());
            tab.placePart(new Castle(tab, Color.White), new chessPosition('e', 1).toPosition());
            tab.placePart(new King(tab, Color.White), new chessPosition('d', 1).toPosition());

            tab.placePart(new Castle(tab, Color.Black), new chessPosition('c', 7).toPosition());
            tab.placePart(new Castle(tab, Color.Black), new chessPosition('c', 8).toPosition());
            tab.placePart(new Castle(tab, Color.Black), new chessPosition('d', 7).toPosition());
            tab.placePart(new Castle(tab, Color.Black), new chessPosition('e', 7).toPosition());
            tab.placePart(new Castle(tab, Color.Black), new chessPosition('e', 8).toPosition());
            tab.placePart(new King(tab, Color.Black), new chessPosition('d', 8).toPosition());
        }

    }
}
