using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeconsole
{
    public class TicTacToeGame
    {
        private enum GameState
        {
            X_TURN, // stabilisce stato del gioco
            O_TURN,
            X_WIN,
            O_WIN,
            TIE_GAME
        }

        private GameState gameState;

        private int[,] boardArray;// stato della scacchiera

        public const int NUM_ROWS = 3;
        public const int NUM_COLUMNS = 3;

        private const int MARK_NONE = 0;// stato casella
        private const int MARK_X = 1;
        private const int MARK_O = 2;

        public TicTacToeGame()
        {
            resetGame();
        }

        public void resetGame()
        {
            this.boardArray = new int[NUM_ROWS, NUM_COLUMNS];
            this.gameState = GameState.X_TURN;
        }

        public void pressedButtonAtLocation(int row, int column)
        {
            if (row < 0 || row >= NUM_ROWS || column < 0 || column >= NUM_COLUMNS)
                return;   // Not a valid square location
            if (boardArray[row, column] != MARK_NONE)
                return;   // Not empty

            if (gameState == GameState.X_TURN)
            {
                boardArray[row, column] = MARK_X;
                gameState = GameState.O_TURN;
            }
            else if (gameState == GameState.O_TURN)
            {
                boardArray[row, column] = MARK_O;
                gameState = GameState.X_TURN;
            }
            checkForWin();
        }

        private void checkForWin()
        {
            if (!(gameState == GameState.X_TURN || gameState == GameState.O_TURN))
                return;

            if (didPieceWin(MARK_X))
            {
                gameState = GameState.X_WIN;
            }
            else if (didPieceWin(MARK_O))
            {
                gameState = GameState.O_WIN;
            }
            else if (isBoardFull())
            {
                gameState = GameState.TIE_GAME;
            }
        }

        private bool isBoardFull()
        {
            for (int row = 0; row < NUM_ROWS; row++)
            {
                for (int col = 0; col < NUM_COLUMNS; col++)
                {
                    if (boardArray[row, col] == MARK_NONE)
                        return false;
                }
            }
            return true;
        }

        private bool didPieceWin(int markType)
        {
            bool allMarksMatch = true;
            // Check all the columns for a win
            for (int col = 0; col < NUM_COLUMNS; col++)
            {
                allMarksMatch = true;
                for (int row = 0; row < NUM_ROWS; row++)
                {
                    if (boardArray[row, col] != markType)
                    {
                        allMarksMatch = false;
                        break;
                    }
                }
                if (allMarksMatch) return true;
            }

            // Check all the rows for a win
            for (int row = 0; row < NUM_ROWS; row++)
            {
                allMarksMatch = true;
                for (int col = 0; col < NUM_COLUMNS; col++)
                {
                    if (boardArray[row, col] != markType)
                    {
                        allMarksMatch = false;
                        break;
                    }
                }
                if (allMarksMatch) return true;
            }

            // Check down right diagonal
            if (boardArray[0, 0] == markType && boardArray[1, 1] == markType && boardArray[2, 2] == markType)
                return true;

            // Check up right diagonal
            if (boardArray[2, 0] == markType && boardArray[1, 1] == markType && boardArray[0, 2] == markType)
                return true;

            return false;
        }

        public String stringForButtonAtLocation(int row, int column)
        {
            String label = " ";
            if (row >= 0 && row < NUM_ROWS && column >= 0 && column < NUM_COLUMNS)
            {
                if (boardArray[row, column] == MARK_X)
                    label = "X";
                else if (boardArray[row, column] == MARK_O)
                    label = "O";
            }
            return label;
        }

        public String stringForGameState()
        {
            String gameStateLabel = "";
            switch (this.gameState)
            {
                case GameState.X_TURN:
                    gameStateLabel = "Turno di X";
                    break;
                case GameState.O_TURN:
                    gameStateLabel = "Turno di O";
                    break;
                case GameState.X_WIN:
                    gameStateLabel = "Ha vinto X";
                    break;
                case GameState.O_WIN:
                    gameStateLabel = "Ha vinto O";
                    break;
                default:
                    gameStateLabel = "Gioco terminato";
                    break;
            }
            return gameStateLabel;
        }
    }
    class Program
    {
        static void output(TicTacToeGame g)
        {
            Console.WriteLine("");
            Console.WriteLine(" /| 0 | 1 | 2 |");
            Console.WriteLine(" --------------");
            Console.WriteLine($" 0| {g.stringForButtonAtLocation(0, 0)} | {g.stringForButtonAtLocation(0, 1)} | {g.stringForButtonAtLocation(0, 2)} |");
            Console.WriteLine(" --------------");
            Console.WriteLine($" 1| {g.stringForButtonAtLocation(1, 0)} | {g.stringForButtonAtLocation(1, 1)} | {g.stringForButtonAtLocation(1, 2)} |");
            Console.WriteLine(" --------------");
            Console.WriteLine($" 2| {g.stringForButtonAtLocation(2, 0)} | {g.stringForButtonAtLocation(2, 1)} | {g.stringForButtonAtLocation(2, 2)} |");
            Console.WriteLine(" --------------");
            Console.WriteLine(g.stringForGameState());
        }
        static void Main(string[] args)
        {
            int x, y;
            TicTacToeGame g=new TicTacToeGame();
            string ris = "";
            do
            {
                Console.Clear();
                g.resetGame();
                Console.WriteLine("Play!");
                //ciclo controllo se gioco finito
                while (!(g.stringForGameState() == "Ha vinto O" || g.stringForGameState() == "Ha vinto X" ||g.stringForGameState()== "Gioco terminato"))
                {
                    output(g);
                    Console.WriteLine("Scrivere le coordinate:");
                    do
                    {
                        Console.Write("Riga:");
                        if (!int.TryParse(Console.ReadLine(),out x))
                            x=-1;
                    } while (x < 0 || x > 2);
                    do
                    {
                        Console.Write("Colonna:");
                        if (!int.TryParse(Console.ReadLine(), out y))
                            y = -1;
                    } while (y < 0 || y > 2);
                    g.pressedButtonAtLocation(x, y);
                    Console.Clear();
                    if ((g.stringForGameState() == "Ha vinto O" || g.stringForGameState() == "Ha vinto X" || g.stringForGameState() == "Gioco terminato"))
                        output(g);
                }
                ris = "";
                while (ris != "S" && ris != "N")
                {
                    Console.WriteLine("Vuoi ripetere?S/N");
                    ris = Console.ReadLine().ToUpper();
                }
            } while (ris=="S");
        }
    }
}
