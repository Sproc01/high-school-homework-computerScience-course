using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[,] mButtons;
        private TicTacToeGame mGame;

        public Form1()
        {
            InitializeComponent();
            // Get a reference to all the buttons
            mButtons = new Button[3, 3];
            mButtons[0, 0] = button00;
            mButtons[0, 1] = button01;
            mButtons[0, 2] = button02;
            mButtons[1, 0] = button10;
            mButtons[1, 1] = button11;
            mButtons[1, 2] = button12;
            mButtons[2, 0] = button20;
            mButtons[2, 1] = button21;
            mButtons[2, 2] = button22;

            mGame = new TicTacToeGame();//modello
            aggiornaView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mGame.resetGame();
            aggiornaView();
        }

        private void aggiornaView()//view  
        {
            for (int row = 0; row < TicTacToeGame.NUM_ROWS; row++)
            {
                for (int col = 0; col < TicTacToeGame.NUM_COLUMNS; col++)
                {
                    mButtons[row, col].Text=mGame.stringForButtonAtLocation(row, col);
                }
            }
            mGameStateTextView.Text= mGame.stringForGameState();
            mGameStateTextView.Left = (this.Width - mGameStateTextView.Width) / 2;
        }

        private void button_Click(object sender, EventArgs e)//controller
        {
            if (sender == button00)
                mGame.pressedButtonAtLocation(0, 0);
            else if (sender == button01)
                mGame.pressedButtonAtLocation(0, 1);
            else if (sender == button02)
                mGame.pressedButtonAtLocation(0, 2);
            else if (sender == button10)
                mGame.pressedButtonAtLocation(1, 0);
            else if (sender == button11)
                mGame.pressedButtonAtLocation(1, 1);
            else if (sender == button12)
                mGame.pressedButtonAtLocation(1, 2);
            else if (sender == button20)
                mGame.pressedButtonAtLocation(2, 0);
            else if (sender == button21)
                mGame.pressedButtonAtLocation(2, 1);
            else if (sender == button22)
                mGame.pressedButtonAtLocation(2, 2);

            aggiornaView();
        }
    }

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
	
	public  const  int NUM_ROWS = 3;
	public  const  int NUM_COLUMNS = 3;
	
	private  const   int MARK_NONE = 0;// stato casella
	private  const   int MARK_X = 1;
	private  const   int MARK_O = 2;
	
	public TicTacToeGame() {
		resetGame();
	}

	public void resetGame() {
		this.boardArray = new int[NUM_ROWS,NUM_COLUMNS];
		this.gameState = GameState.X_TURN;
	}

	public void pressedButtonAtLocation(int row, int column) {
		if (row<0 || row>=NUM_ROWS || column<0 || column>=NUM_COLUMNS)
			return;   // Not a valid square location
		if (boardArray[row,column] != MARK_NONE)
			return;   // Not empty
		
		if (gameState == GameState.X_TURN) {
			boardArray[row,column] = MARK_X;
			gameState = GameState.O_TURN;
		} else if (gameState == GameState.O_TURN) {
			boardArray[row,column] = MARK_O;
			gameState = GameState.X_TURN;
		}
		checkForWin();
	}

	private void checkForWin() {
		if (!(gameState == GameState.X_TURN || gameState == GameState.O_TURN))
			return;
		
		if (didPieceWin(MARK_X)) {
			gameState = GameState.X_WIN;
		} else if (didPieceWin(MARK_O)) {
			gameState = GameState.O_WIN;
		} else if (isBoardFull()) {
			gameState = GameState.TIE_GAME;
		}
	}

	private bool isBoardFull() {
		for (int row = 0 ; row<NUM_ROWS ; row++) {
			for (int col = 0 ; col<NUM_COLUMNS ; col++) {
				if (boardArray[row,col] == MARK_NONE) 
					return false;
			}
		}
		return true;
	}

	private bool didPieceWin(int markType) {
		bool allMarksMatch = true;
		// Check all the columns for a win
		for (int col=0 ; col<NUM_COLUMNS ; col++) 
        	{
		    allMarksMatch = true;
		    for (int row=0 ; row<NUM_ROWS ; row++) 
            	    {
			if (boardArray[row,col] != markType) 
                	{
				allMarksMatch = false;
				break;
			}
		    }
		    if (allMarksMatch) return true;
		}
		
		// Check all the rows for a win
		for (int row=0 ; row<NUM_ROWS ; row++) {
		    allMarksMatch = true;
		    for (int col=0 ; col<NUM_COLUMNS ; col++) 
            	    {
			if (boardArray[row,col] != markType) 
                	{
			   allMarksMatch = false;
			   break;
			}
		    }
		    if (allMarksMatch) return true;
		}
		
		// Check down right diagonal
		if (boardArray[0,0]==markType && boardArray[1,1]==markType && boardArray[2,2]==markType)
			return true;
		
		// Check up right diagonal
		if (boardArray[2,0]==markType && boardArray[1,1]==markType && boardArray[0,2]==markType)
			return true;
		
		return false;
	}

	public String stringForButtonAtLocation(int row, int column) {
		String label = "";
		if (row>=0 && row<NUM_ROWS && column>=0 && column<NUM_COLUMNS)
		{
			if (boardArray[row,column] == MARK_X) 
                label = "X";
			else if (boardArray[row,column] == MARK_O) 
				label = "Z";
		}
		return label;
	}

	public String stringForGameState() {
		String gameStateLabel = "";
		switch (this.gameState) {
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
}
